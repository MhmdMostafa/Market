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
    public partial class AddEditSup : MaterialSkin.Controls.MaterialForm
    {
        
        public string command;
        public int SelectedID;
        
        public Dictionary<string, int> suppliersCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersEmailAddressesCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersContactNumbersCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersBankAccountsCol = new Dictionary<string, int>();
        public AddEditSup()
        {
            InitializeComponent();
        }

        public AddEditSup(string conf, int id = 0)
        {
            InitializeComponent();
            suppliersCol = Globals.GetColumnsIndex("suppliers");
            suppliersEmailAddressesCol = Globals.GetColumnsIndex("Suppliers_email_addresses");
            suppliersContactNumbersCol = Globals.GetColumnsIndex("Suppliers_contact_numbers");
            suppliersBankAccountsCol = Globals.GetColumnsIndex("Suppliers_bank_accounts");
            SelectedID = id;
            command = conf;
            string SQLquary;


            
            ContactDGV.AutoGenerateColumns = false;
            BankDGV.AutoGenerateColumns = false;
            if (conf == "add")
            {
                Text = "Add new Supplaier Wizerd";
            }
            else
            {
                CancelBack.Visible = false;
                NextEnd.Text = "Done";
                Text = "Edit Supplaier Wizerd";
                SQLquary = $"SELECT * FROM suppliers WHERE SupplierID = {SelectedID}";
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQLquary))
                {
                    dr.Read();
                    GNameEnTB.Text = dr.IsDBNull(suppliersCol["SupplierNameEN"]) ? "" : dr.GetString("SupplierNameEN");
                    GNameArTB.Text = dr.IsDBNull(suppliersCol["SupplierNameAR"]) ? "" : dr.GetString("SupplierNameAR");
                    GVatTB.Text = dr.IsDBNull(suppliersCol["SupplierVatNumber"]) ? "":dr.GetString("SupplierVatNumber") ;
                    GDiscRTB.Text = dr.IsDBNull(suppliersCol["Discrption"]) ? "" : dr.GetString("Discrption");
                }
            }

            

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
                    SQL = $"SELECT * FROM suppliers WHERE SupplierID = {SelectedID}";
                    using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                    {
                        dr.Read();
                        GNameEnTB.Text = dr.IsDBNull(suppliersCol["SupplierNameEN"]) ? "" : dr.GetString("SupplierNameEN");
                        GNameArTB.Text = dr.IsDBNull(suppliersCol["SupplierNameAR"]) ? "" : dr.GetString("SupplierNameAR");
                        GVatTB.Text = dr.IsDBNull(suppliersCol["SupplierVatNumber"]) ? "" : dr.GetString("SupplierVatNumber");
                        GDiscRTB.Text = dr.IsDBNull(suppliersCol["Discrption"]) ? "" : dr.GetString("Discrption");
                    }
                    break;
                case "Emails":
                    cleanCB(EmailsCBL);
                    using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM suppliers_email_addresses WHERE UserID = {SelectedID}"))
                    {
                        while (dr.Read())
                        {
                            EmailsCBL.Items.Add(dr.GetString("EmailAddress"));
                        }
                    }
                    break;
                case "Contact":
                    SQL = $"SELECT ContactID, ContactNumber, countries.Shortcut, contact_type.ContactNameEN FROM suppliers_contact_numbers INNER JOIN countries ON suppliers_contact_numbers.CountryID=countries.CountryID INNER JOIN contact_type ON suppliers_contact_numbers.ContactTypeID=contact_type.ContactTypeID WHERE UserID = {SelectedID};";
                    ContactDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
                    break;
                case "Bank Acconts":
                    BankDGV.Rows.Clear();
                    break;
            }
        }

        

        private void NextEnd_Click(object sender, EventArgs e)
        {

        }

        private void EditEmailB_Click(object sender, EventArgs e)
        {
            if (Globals.CoutCbList(EmailsCBL))
            {
                AddEemail AddWindow = new AddEemail("edit", "suppliers_email_addresses", SelectedID,EmailsCBL.CheckedItems[0].ToString());
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
            string selected= "Are you sure you wanna Delete\n";
            if (EmailsCBL.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select any value");
            }
            else
            {
                foreach (object item in EmailsCBL.CheckedItems)
                {
                    selected+=$"{item.ToString()}\n";
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
    }
}
