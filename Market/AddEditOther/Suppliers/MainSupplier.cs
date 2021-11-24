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
    public partial class MainSupplier : MaterialSkin.Controls.MaterialForm
    {

        public string command;
        public int SelectedID;

        public Dictionary<string, int> suppliersCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersEmailAddressesCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersContactNumbersCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersBankAccountsCol = new Dictionary<string, int>();
        public MainSupplier()
        {
            InitializeComponent();
        }

        public MainSupplier(string conf, int id = 0)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;
            suppliersCol = Globals.GetColumnsIndex("suppliers");
            suppliersEmailAddressesCol = Globals.GetColumnsIndex("Suppliers_email_addresses");
            suppliersContactNumbersCol = Globals.GetColumnsIndex("Suppliers_contact_numbers");
            suppliersBankAccountsCol = Globals.GetColumnsIndex("Suppliers_bank_accounts");


            ContactDGV.AutoGenerateColumns = false;
            BankDGV.AutoGenerateColumns = false;

            if (conf == "add")
            {
                Text = "Add new Supplaier Wizerd";
                ((Control)EmailTP).Enabled = false;
                ((Control)ContactTP).Enabled = false;
                ((Control)BankTP).Enabled = false;


            }
            else
            {
                CancelBack.Visible = false;
                NextEnd.Text = "Done";
                Text = "Edit Supplaier Wizerd";
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
                        SQL = $"SELECT * FROM suppliers WHERE ID = {SelectedID}";
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                        {
                            dr.Read();
                            GNameEnTB.Text = dr.IsDBNull(suppliersCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            GNameArTB.Text = dr.IsDBNull(suppliersCol["NameAr"]) ? "" : dr.GetString("NameAr");
                            GVatTB.Text = dr.IsDBNull(suppliersCol["VatNumber"]) ? "" : dr.GetString("VatNumber");
                            GDiscRTB.Text = dr.IsDBNull(suppliersCol["Description"]) ? "" : dr.GetString("Description");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM suppliers_email_addresses WHERE UserID = {SelectedID}"))
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
                        SQL = $"SELECT suppliers_contact_numbers.ID, ContactNumber, countries.Shortcut, contact_type.NameEn as ContactType FROM suppliers_contact_numbers INNER JOIN countries ON suppliers_contact_numbers.CountryID=countries.ID INNER JOIN contact_type ON suppliers_contact_numbers.ContactTypeID=contact_type.ID WHERE UserID ={SelectedID};";
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
                        SQL = $"SELECT ID, NameEn, NameAr, Iban, FullNameOwner, ExpiryDate FROM suppliers_bank_accounts WHERE UserID = {SelectedID};";
                        BankDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
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

            if (GNameArTB.Text == "" || GNameEnTB.Text == "" || GVatTB.Text == "" || GDiscRTB.Text == "")
            {
                MessageBox.Show("Please fill all feilds");
                return;
            }

            if (command == "edit" || SelectedID != 0)
            {
                if (Globals.ifExist("suppliers", "VatNumber", Globals.RmSpace(GVatTB.Text), SelectedID))
                {
                    MessageBox.Show("This Vat Number is alredy Exist");
                    return;
                }
                SQL = $"UPDATE suppliers SET NameEn=@NameEn, NameAr=@NameAr, VatNumber=@VatNumber, Description=@Description WHERE ID={SelectedID};";

            }
            else
            {

                if (Globals.ifExist("suppliers", "VatNumber", Globals.RmSpace(GVatTB.Text)))
                {
                    MessageBox.Show("This Vat Number is alredy Exist");
                    return;
                }

                SQL = $"INSERT INTO suppliers (NameEn, NameAr, VatNumber, Description) VALUES(@NameEn, @NameAr, @VatNumber, @Description);";

            }

            myPara.Add("@NameEn", Globals.RmSpace(GNameEnTB.Text));
            myPara.Add("@NameAr", Globals.RmSpace(GNameArTB.Text));
            myPara.Add("@VatNumber", Globals.RmSpace(GVatTB.Text));
            myPara.Add("@Description", Globals.RmSpace(GDiscRTB.Text));
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
                    myPara.Add("@VatNumber", Globals.RmSpace(GVatTB.Text));
                    using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic("SELECT ID FROM suppliers WHERE VatNumber = @VatNumber;", myPara))
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
                AddEemail AddWindow = new AddEemail("edit", "suppliers_email_addresses", SelectedID, EmailsCBL.CheckedItems[0].ToString());
                AddWindow.ShowDialog();
                refreshTap();
            }
        }

        private void AddEmailB_Click(object sender, EventArgs e)
        {
            AddEemail AddWindow = new AddEemail("add", "suppliers_email_addresses", SelectedID);
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
                        Globals.DeleteValue("suppliers_email_addresses", "EmailAddress", item.ToString());
                    }
                    refreshTap();
                }


            }
        }

        private void AddContactB_Click(object sender, EventArgs e)
        {
            AddContact window = new AddContact("add", "suppliers_contact_numbers", SelectedID);
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

            AddContact window = new AddContact("edit", "suppliers_contact_numbers", SelectedID, selectedValues[0]);
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
                Globals.DeleteValue("suppliers_contact_numbers", "ID", value);
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
            AddEditBank window = new AddEditBank("add", "suppliers_bank_accounts", SelectedID);
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

            AddEditBank window = new AddEditBank("edit", "suppliers_bank_accounts", SelectedID, selectedValues[0]);
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
                Globals.DeleteValue("suppliers_bank_accounts", "ID", value);
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
            if (GVatTB.Text.Length > 23 && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CancelBack_Click(object sender, EventArgs e)
        {
            TapsPage.SelectedIndex -= 1;
        }
    }
}
