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
    public partial class AddEditcu : MaterialSkin.Controls.MaterialForm
    {
        
        public string command;
        public int SelctedID;
        
        public Dictionary<string, int> suppliersCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersEmailAddressesCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersContactNumbersCol = new Dictionary<string, int>();
        public Dictionary<string, int> suppliersBankAccountsCol = new Dictionary<string, int>();
        public AddEditcu()
        {
            InitializeComponent();
        }

        public AddEditcu(string conf, int id = 0)
        {
            InitializeComponent();
            suppliersCol = Globals.GetColumnsIndex("suppliers");
            suppliersEmailAddressesCol = Globals.GetColumnsIndex("Suppliers_email_addresses");
            suppliersContactNumbersCol = Globals.GetColumnsIndex("Suppliers_contact_numbers");
            suppliersBankAccountsCol = Globals.GetColumnsIndex("Suppliers_bank_accounts");
            SelctedID = id;
            command = conf;
            string SQLquary;


            EmailDGV.AutoGenerateColumns = false;
            AddressDGV.AutoGenerateColumns = false;
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
                SQLquary = $"SELECT * FROM suppliers WHERE SupplierID = {SelctedID}";
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
            string SQL;

            if (command == "add")
                switch (TapsPage.SelectedTab.Text)
                {
                    case "General":

                        break;
                    case "Emails":

                        break;
                    case "Address":

                        break;
                    case "Contacts":

                        break;
                    case "Bank Acconts":

                        break;
                }
            else
                switch (TapsPage.SelectedTab.Text)
                {
                    case "General":
                        SQL = $"SELECT * FROM suppliers WHERE SupplierID = {SelctedID}";
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
                        SQL = $"SELECT UserID, EmailAddress FROM suppliers_email_addresses WHERE UserID = {SelctedID}";

                        DataTable dt = Globals.myCrud.getDtPassSql(SQL);
                        EmailDGV.DataSource = dt;




                        break;
                    case "Address":
                        AddressDGV.Rows.Clear();
                        break;
                    case "Contacts":
                        ContactDGV.Rows.Clear();
                        break;
                    case "Bank Acconts":
                        BankDGV.Rows.Clear();
                        break;
                }

        }
        private void cleanCB(CheckedListBox CB)
        {
            for (int i = CB.Items.Count - 1; i >= 0; i--)
            {
                CB.Items.RemoveAt(i);
            }
        }

        

        private void NextEnd_Click(object sender, EventArgs e)
        {

        }

        private void EditEmailB_Click(object sender, EventArgs e)
        {

        }
    }
}
