using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Market
{
    public partial class MainEmp : MaterialSkin.Controls.MaterialForm
    {

        public string command;
        public int SelectedID;

        public Dictionary<string, int> employeesCol = new Dictionary<string, int>();
        public Dictionary<string, int> employeeEmailAddressesCol = new Dictionary<string, int>();
        public Dictionary<string, int> employeeContactNumbersCol = new Dictionary<string, int>();
        public Dictionary<string, int> employeeBankAccountsCol = new Dictionary<string, int>();
        public Dictionary<string, int> empGroupCol = new Dictionary<string, int>();

        public MainEmp()
        {
            InitializeComponent();
        }

        public MainEmp(string conf, int id = 0)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;
            employeesCol = Globals.GetColumnsIndex("employees");
            employeeEmailAddressesCol = Globals.GetColumnsIndex("emp_email_addresses");
            employeeContactNumbersCol = Globals.GetColumnsIndex("emp_contact_numbers");
            employeeBankAccountsCol = Globals.GetColumnsIndex("emp_bank_accounts");
            empGroupCol = Globals.GetColumnsIndex("emp_group");
            using (MySqlDataReader dr=Globals.myCrud.getDrPassSql("SELECT * FROM emp_group"))
            {
                while (dr.Read())
                    GGroupCb.Items.Add(dr.IsDBNull(empGroupCol["NameEn"]) ? "" : dr.GetString("NameEn"));
            }

            ContactDGV.AutoGenerateColumns = false;
            BankDGV.AutoGenerateColumns = false;

            if (conf == "add")
            {
                Text = "Add new Customer Wizerd";
                ((Control)EmailTP).Enabled = false;
                ((Control)ContactTP).Enabled = false;
                ((Control)BankTP).Enabled = false;
                ((Control)Addresses).Enabled = false;


            }
            else
            {
                Text = "Edit Customer Wizerd";
                CancelBack.Visible = false;
                NextEnd.Text = "Done";
                Text = "Edit Customer Wizerd";
            }

            refreshTap();

        }

        private void TabsPage_SelectedIndexChanged(Object sender, EventArgs e)
        {
            refreshTap();
        }
        private void cleanCB(CheckedListBox CB)
        {
            for (int i = CB.Items.Count - 1; i >= 0; i--)
            {
                CB.Items.RemoveAt(i);
            }
        }

        private void refreshTap()
        {
            string SQL;
            switch (TapsPage.SelectedTab.Text)
            {
                case "General":
                    if (SelectedID != 0)
                    {
                        SQL = $"SELECT * FROM employees WHERE ID = {SelectedID}";
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                        {
                            dr.Read();
                            GUserNameTB.Text = dr.IsDBNull(employeesCol["UserName"]) ? "" : dr.GetString("UserName");
                            GNameEnTB.Text = dr.IsDBNull(employeesCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            GNameArTB.Text = dr.IsDBNull(employeesCol["NameAr"]) ? "" : dr.GetString("NameAr");
                            dateTimePicker.Text = dr.IsDBNull(employeesCol["DateOfBirh"]) ? "" : dr.GetString("DateOfBirh");
                            GNationalTB.Text = dr.IsDBNull(employeesCol["Pass_word"]) ? "" : dr.GetString("Pass_word");
                            GGroupCb.SelectedItem = dr.IsDBNull(employeesCol["EmpGroupID"]) ? "" : Globals.GetStringById("NameEn", "emp_group", dr.GetInt32("EmpGroupID"));

                        }
                    }
                    if (command == "add")
                    {
                        NextEnd.Text = "Next";
                        CancelBack.Visible = false;
                    }

                    break;

                case "Emails":
                    if (SelectedID != 0)
                    {
                        cleanCB(EmailsCBL);
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM emp_email_addresses WHERE UserID = {SelectedID}"))
                            while (dr.Read())
                                EmailsCBL.Items.Add(dr.GetString("EmailAddress"));
                    }
                    if (command == "add")
                    {
                        NextEnd.Text = "Next";
                        CancelBack.Visible = true;
                    }
                    break;

                case "Contact":
                    if (SelectedID != 0)
                    {
                        SQL = $"SELECT emp_contact_numbers.ID, ContactNumber, countries.Shortcut, contact_type.NameEn as ContactType FROM emp_contact_numbers INNER JOIN countries ON emp_contact_numbers.CountryID=countries.ID INNER JOIN contact_type ON emp_contact_numbers.ContactTypeID=contact_type.ID WHERE UserID ={SelectedID};";
                        ContactDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
                    }
                    if (command == "add")
                    {
                        NextEnd.Text = "Next";
                        CancelBack.Visible = true;
                    }
                    break;

                case "Bank Accounts":
                    if (SelectedID != 0)
                    {
                        SQL = $"SELECT ID, NameEn, NameAr, Iban, FullNameOwner, ExpiryDate FROM emp_bank_accounts WHERE UserID = {SelectedID};";
                        BankDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
                    }
                    if (command == "add")
                    {
                        NextEnd.Text = "Next";
                        CancelBack.Visible = true;
                    }
                    break;
                case "Addresses":
                    if (SelectedID != 0)
                    {
                        SQL = $"SELECT customer_Addresses.ID, countries.NameEn as Country, cities.NameEn as City, District, Street, ZipCode, Description FROM customer_Addresses INNER JOIN countries ON customer_Addresses.CountryID = countries.ID INNER JOIN cities ON customer_Addresses.CityID = cities.ID WHERE UserID = {SelectedID};";
                        AddressDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
                    }
                    if (command == "add")
                    {
                        NextEnd.Text = "Done";
                        CancelBack.Visible = true;
                    }
                    break;
            }
        }



        private void NextEnd_Click(object sender, EventArgs e)
        {
            string SQL;
            Dictionary<string, object> myPara = new Dictionary<string, object>();

            if (GNameArTB.Text == "" || GNameEnTB.Text == "" || GUserNameTB.Text == "")
            {
                MessageBox.Show("Please fill all feilds");
                return;
            }

            if (command == "edit" || SelectedID != 0)
            {
                if (Globals.ifExist("employees", "UserName", Globals.RmSpace(GUserNameTB.Text), SelectedID))
                {
                    MessageBox.Show("This Vat Number is alredy Exist");
                    return;
                }
                SQL = $"UPDATE employees SET UserName=@UserName, NameEn=@NameEn, NameAr=@NameAr, DateOfBirh=@DateOfBirh, Pass_word=MD5(@Pass_word), EmpGroupID=@EmpGroupID WHERE ID={SelectedID};";

            }
            else
            {

                if (Globals.ifExist("employees", "UserName", Globals.RmSpace(GUserNameTB.Text)))
                {
                    MessageBox.Show("This Vat Number is alredy Exist");
                    return;
                }

                SQL = $"INSERT INTO employees (UserName, NameEn, NameAr, DateOfBirh, Pass_word, EmpGroupID) VALUES(@UserName, @NameEn, @NameAr, @DateOfBirh, MD5(@Pass_word), @EmpGroupID);";

            }
            myPara.Add("@UserName", Globals.RmSpace(GUserNameTB.Text));
            myPara.Add("@NameEn", Globals.RmSpace(GNameEnTB.Text));
            myPara.Add("@NameAr", Globals.RmSpace(GNameArTB.Text));
            myPara.Add("@DateOfBirh", dateTimePicker.Value);
            myPara.Add("@Pass_word", Globals.RmSpace(GNationalTB.Text));
            myPara.Add("@EmpGroupID", Globals.GetIdByString("emp_group", "NameEn", GGroupCb.Text));

            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            ((Control)EmailTP).Enabled = true;
            ((Control)ContactTP).Enabled = true;
            ((Control)BankTP).Enabled = true;

            if (NextEnd.Text == "Done")
                this.Close();
            else if (NextEnd.Text == "Next")
            {
                if (SelectedID == 0)
                {
                    myPara.Clear();
                    myPara.Add("@UserName", Globals.RmSpace(GUserNameTB.Text));
                    using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic("SELECT ID FROM employees WHERE UserName = @UserName;", myPara))
                    {
                        dr.Read();
                        SelectedID = dr.GetInt32("ID");
                    }

                }
                TapsPage.SelectedIndex += 1;

            }


        }

        private void EditEmailB_Click(object sender, EventArgs e)
        {
            if (Globals.CoutCbList(EmailsCBL))
            {
                AddEemail AddWindow = new AddEemail("edit", "emp_email_addresses", SelectedID, EmailsCBL.CheckedItems[0].ToString());
                AddWindow.ShowDialog();
                refreshTap();
            }
        }

        private void AddEmailB_Click(object sender, EventArgs e)
        {
            AddEemail AddWindow = new AddEemail("add", "emp_email_addresses", SelectedID);
            AddWindow.ShowDialog();
            refreshTap();

        }

        private void SelectAllEmailsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllEmailsCb.Checked)
                Globals.Clean_SelectCbList(EmailsCBL, true);
            else
                Globals.Clean_SelectCbList(EmailsCBL, false);

        }

        private void DeleteEmailB_Click(object sender, EventArgs e)
        {
            string selected = "Are you sure you wanna Delete\n";
            if (EmailsCBL.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select any value");
            }
            else
            {
                foreach (object item in EmailsCBL.CheckedItems)
                {
                    selected += $"{item.ToString()}\n";
                }
                DialogResult d = MessageBox.Show(selected, command.ToUpper(), MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {

                    foreach (object item in EmailsCBL.CheckedItems)
                    {
                        Globals.DeleteValue("emp_email_addresses", "EmailAddress", item.ToString());
                    }
                    refreshTap();
                }


            }
        }

        private void AddContactB_Click(object sender, EventArgs e)
        {
            AddContact window = new AddContact("add", "emp_contact_numbers", SelectedID);
            window.ShowDialog();
            refreshTap();
        }

        private void EditContactB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(ContactDGV);
            if (selectedValues.Count > 1)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }
            else if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }

            AddContact window = new AddContact("edit", "emp_contact_numbers", SelectedID, selectedValues[0]);
            window.ShowDialog();
            refreshTap();
        }

        private void DeleteContactB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(ContactDGV);
            if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to Delete");
                return;
            }

            foreach (int value in selectedValues)
            {
                Globals.DeleteValue("emp_contact_numbers", "ID", value);
            }

            MessageBox.Show("Done!!");
            refreshTap();
        }

        private void ContactAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ContactAllCb.Checked)
                Globals.Clean_SelectCbList(ContactDGV, true);
            else
                Globals.Clean_SelectCbList(ContactDGV, false);
        }

        private void AddBankB_Click(object sender, EventArgs e)
        {
            AddEditBank window = new AddEditBank("add", "emp_bank_accounts", SelectedID);
            window.ShowDialog();
            refreshTap();
        }

        private void EditBankB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(BankDGV);
            if (selectedValues.Count > 1)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }
            else if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }

            AddEditBank window = new AddEditBank("edit", "emp_bank_accounts", SelectedID, selectedValues[0]);
            window.ShowDialog();
            refreshTap();
        }

        private void DeleteBankB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(BankDGV);
            if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to Delete");
                return;
            }

            foreach (int value in selectedValues)
            {
                Globals.DeleteValue("emp_bank_accounts", "ID", value);
            }

            MessageBox.Show("Done!!");
            refreshTap();
        }

        private void BnCheckAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BnCheckAllCb.Checked)
                Globals.Clean_SelectCbList(BankDGV, true);
            else
                Globals.Clean_SelectCbList(BankDGV, false);
        }

        private void GVatTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GUserNameTB.Text.Length > 23 && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CancelBack_Click(object sender, EventArgs e)
        {
            TapsPage.SelectedIndex -= 1;
        }

        private void AddAddressB_Click(object sender, EventArgs e)
        {
            AddEditAddress window = new AddEditAddress("add", "customer_Addresses", SelectedID);
            window.ShowDialog();
            refreshTap();
        }

        private void EditAddressB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(AddressDGV);
            if (selectedValues.Count > 1)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }
            else if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }

            AddEditAddress window = new AddEditAddress("edit", "customer_Addresses", SelectedID, selectedValues[0]);
            window.ShowDialog();
            refreshTap();
        }

        private void DeleteAddressB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(AddressDGV);
            if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to Delete");
                return;
            }

            foreach (int value in selectedValues)
            {
                Globals.DeleteValue("customer_Addresses", "ID", value);
            }

            MessageBox.Show("Done!!");
            refreshTap();
        }

        private void AddressSelectAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (AddressSelectAllCb.Checked)
                Globals.Clean_SelectCbList(AddressDGV, true);
            else
                Globals.Clean_SelectCbList(AddressDGV, false);
        }
    }
}
