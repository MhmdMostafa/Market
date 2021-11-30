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
    public partial class MainCustomer : MaterialSkin.Controls.MaterialForm
    {

        public string command;
        public int SelectedID;

        public Dictionary<string, int> customersCol = new Dictionary<string, int>();
        public Dictionary<string, int> customersEmailAddressesCol = new Dictionary<string, int>();
        public Dictionary<string, int> customersContactNumbersCol = new Dictionary<string, int>();
        public Dictionary<string, int> customersBankAccountsCol = new Dictionary<string, int>();
        public Dictionary<string, int> customerGroupsCol = new Dictionary<string, int>();
        public Dictionary<string, int> genderCol = new Dictionary<string, int>();

        public MainCustomer()
        {
            InitializeComponent();
        }

        public MainCustomer(string conf, int id = 0)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;
            customersCol = Globals.GetColumnsIndex("customers");
            customersEmailAddressesCol = Globals.GetColumnsIndex("customer_email_addresses");
            customersContactNumbersCol = Globals.GetColumnsIndex("customer_contact_numbers");
            customersBankAccountsCol = Globals.GetColumnsIndex("customer_bank_accounts");
            customerGroupsCol = Globals.GetColumnsIndex("customer_groups");
            genderCol = Globals.GetColumnsIndex("gender");

            using (MySqlDataReader dr=Globals.myCrud.getDrPassSql("SELECT * FROM customer_groups"))
                while (dr.Read())
                    GGroupCb.Items.Add(dr.IsDBNull(customerGroupsCol["NameEn"]) ? "" : dr.GetString("NameEn"));
            GGroupCb.SelectedIndex = 0;

            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM gender"))
                while (dr.Read())
                    GenderCb.Items.Add(dr.IsDBNull(genderCol["NameEn"]) ? "" : dr.GetString("NameEn"));
            GenderCb.SelectedIndex = 0;

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
                        
                        SQL = $"SELECT * FROM customers WHERE ID = {SelectedID}";
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                        {
                            dr.Read();
                            GUserNameTB.Text = dr.IsDBNull(customersCol["UserName"]) ? "" : dr.GetString("UserName");
                            GNameEnTB.Text = dr.IsDBNull(customersCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            GNameArTB.Text = dr.IsDBNull(customersCol["NameAr"]) ? "" : dr.GetString("NameAr");
                            dateTimePicker.Text = dr.IsDBNull(customersCol["BirthDate"]) ? "" : dr.GetString("BirthDate");
                            GNationalTB.Text = dr.IsDBNull(customersCol["NationalNumber"]) ? "" : dr.GetString("NationalNumber");
                            GGroupCb.SelectedItem = dr.IsDBNull(customersCol["CustomerGroupID"]) ? "" : Globals.GetStringById("NameEn", "customer_groups", dr.GetInt32("CustomerGroupID"));
                            GenderCb.SelectedItem = dr.IsDBNull(customersCol["GenderID"]) ? "" : Globals.GetStringById("NameEn", "gender", dr.GetInt32("GenderID"));
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM customer_email_addresses WHERE UserID = {SelectedID}"))
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
                        SQL = $"SELECT customer_contact_numbers.ID, ContactNumber, countries.Shortcut, contact_type.NameEn as ContactType FROM customer_contact_numbers INNER JOIN countries ON customer_contact_numbers.CountryID=countries.ID INNER JOIN contact_type ON customer_contact_numbers.ContactTypeID=contact_type.ID WHERE UserID ={SelectedID};";
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
                        SQL = $"SELECT ID, NameEn, NameAr, Iban, FullNameOwner, ExpiryDate FROM customer_bank_accounts WHERE UserID = {SelectedID};";
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
            if (TapsPage.SelectedIndex == 0) {
                string SQL;
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                Globals.CleanTB(this.Controls);
                GUserNameTB.Text = GUserNameTB.Text.ToLower();
                if (GNameArTB.Text == "" || GNameEnTB.Text == "" || GUserNameTB.Text == "")
                {
                    MessageBox.Show("Please fill all feilds");
                    return;
                }

                if (command == "edit" || SelectedID != 0)
                {
                    if (Globals.ifExist("customers", "UserName", GUserNameTB.Text, SelectedID))
                    {
                        MessageBox.Show("This Vat Number is alredy Exist");
                        return;
                    }
                    SQL = $"UPDATE customers SET UserName=@UserName NameEn=@NameEn, NameAr=@NameAr, BirthDate=@BirthDate, NationalNumber=@NationalNumber, CustomerGroupID=@CustomerGroupID, GenderID=@GenderID WHERE ID={SelectedID};";

                }
                else
                {

                    if (Globals.ifExist("customers", "UserName", GUserNameTB.Text))
                    {
                        MessageBox.Show("This Vat Number is alredy Exist");
                        return;
                    }

                    SQL = $"INSERT INTO customers (UserName, NameEn, NameAr, BirthDate, NationalNumber, CustomerGroupID, GenderID) VALUES(@UserName, @NameEn, @NameAr, @BirthDate, @NationalNumber, @CustomerGroupID, @GenderID);";

                }
                myPara.Add("@UserName", GUserNameTB.Text);
                myPara.Add("@NameEn", GNameEnTB.Text);
                myPara.Add("@NameAr", GNameArTB.Text);
                myPara.Add("@BirthDate", dateTimePicker.Value);
                myPara.Add("@NationalNumber", GNationalTB.Text);
                myPara.Add("@CustomerGroupID", Globals.GetIdByString("customer_groups", "NameEn", GGroupCb.Text));
                myPara.Add("@GenderID", Globals.GetIdByString("gender", "NameEn", GenderCb.Text));


                Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                ((Control)EmailTP).Enabled = true;
                ((Control)ContactTP).Enabled = true;
                ((Control)BankTP).Enabled = true;
                if (SelectedID == 0)
                    SelectedID = Globals.GetIdByString("customers","UserName", GUserNameTB.Text);

            }
            

            if (NextEnd.Text == "Done")
                this.Close();
            else if (NextEnd.Text == "Next")
                TapsPage.SelectedIndex += 1;

            


        }

        private void EditEmailB_Click(object sender, EventArgs e)
        {
            if (Globals.CoutCbList(EmailsCBL))
            {
                AddEemail AddWindow = new AddEemail("edit", "customer_email_addresses", SelectedID, EmailsCBL.CheckedItems[0].ToString());
                AddWindow.ShowDialog();
                refreshTap();
            }
        }

        private void AddEmailB_Click(object sender, EventArgs e)
        {
            AddEemail AddWindow = new AddEemail("add", "customer_email_addresses", SelectedID);
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
                        Globals.DeleteValue("customer_email_addresses", "EmailAddress", item.ToString());
                    }
                    refreshTap();
                }


            }
        }

        private void AddContactB_Click(object sender, EventArgs e)
        {
            AddContact window = new AddContact("add", "customer_contact_numbers", SelectedID);
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

            AddContact window = new AddContact("edit", "customer_contact_numbers", SelectedID, selectedValues[0]);
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
                Globals.DeleteValue("customer_contact_numbers", "ID", value);
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
            AddEditBank window = new AddEditBank("add", "customer_bank_accounts", SelectedID);
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

            AddEditBank window = new AddEditBank("edit", "customer_bank_accounts", SelectedID, selectedValues[0]);
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
                Globals.DeleteValue("customer_bank_accounts", "ID", value);
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

        private void GNationalTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;

            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || GNationalTB.Text.Length > 11)
            {
                e.Handled = true;
            }
        }
    }
}
