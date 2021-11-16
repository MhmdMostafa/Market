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
        public int SelctedID;
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
            suppliersEmailAddressesCol = Globals.GetColumnsIndex("suppliers_email_addresses");
            suppliersContactNumbersCol = Globals.GetColumnsIndex("suppliers_contact_numbers");
            suppliersBankAccountsCol = Globals.GetColumnsIndex("suppliers_bank_accounts");
            SelctedID = id;
            command = conf;
            string SQLquary;
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
                    GNameEnTB.Text = dr.IsDBNull(suppliersCol["supplierNameEN"]) ? "" : dr.GetString("supplierNameEN");
                    GNameArTB.Text = dr.IsDBNull(suppliersCol["supplierNameAR"]) ? "" : dr.GetString("supplierNameAR");
                    GVatTB.Text = dr.IsDBNull(suppliersCol["supplierVatNumber"]) ? "":dr.GetString("supplierVatNumber") ;
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM suppliers WHERE SupplierID = {SelctedID}"))
                        {
                            dr.Read();
                            GNameEnTB.Text = dr.GetString("supplierNameEN");
                            GNameArTB.Text = dr.GetString("supplierNameAR");
                            GVatTB.Text = dr.GetString("supplierVatNumber");
                            GDiscRTB.Text = dr.GetString("Discrption");
                        }
                        break;
                    case "Emails":
                        cleanCB(EmailsCBL);
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM suppliers_email_addresses WHERE SupplierID = {SelctedID}"))
                        {
                            while (dr.Read())
                            {
                                EmailsCBL.Items.Add(dr.GetString("EmailAddress"));
                            }
                        }
                        break;
                    case "Address":
                        cleanCB(AddressesCBL);
                        break;

                    case "Contacts":
                        cleanCB(ContactsCBL);
                        break;
                    case "Bank Acconts":
                        cleanCB(BanksCBL);
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
