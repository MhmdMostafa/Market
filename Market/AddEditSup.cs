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
        public AddEditSup()
        {
            InitializeComponent();
        }

        public AddEditSup(string conf, int id = 0)
        {
            InitializeComponent();
            SelctedID = id;
            command = conf;
            if (conf == "add")
            {
                Text = "Add new Supplaier Wizerd";
            }
            else
            {
                CancelBack.Visible = false;
                NextEnd.Text = "Done";
                Text = "Edit Supplaier Wizerd";
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM suppliers WHERE SupplierID = {SelctedID}"))
                {
                    dr.Read();
                    GNameEnTB.Text = dr.GetString("supplierNameEN");
                    GNameArTB.Text = dr.GetString("supplierNameAR");
                    GVatTB.Text = dr.GetString("supplierVatNumber");
                    GDiscRTB.Text = dr.GetString("Discrption");
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
