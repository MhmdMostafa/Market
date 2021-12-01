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
    public partial class MainWarehouses : MaterialSkin.Controls.MaterialForm
    {

        public string command;
        public int SelectedID;

        public Dictionary<string, int> warehousesCol = new Dictionary<string, int>();
        public Dictionary<string, int> warehousesEmailAddressesCol = new Dictionary<string, int>();
        public Dictionary<string, int> warehousesContactNumbersCol = new Dictionary<string, int>();
        public Dictionary<string, int> warehousesTypeCol = new Dictionary<string, int>();

        public MainWarehouses()
        {
            InitializeComponent();
        }

        public MainWarehouses(string conf, int id = 0)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;
            warehousesCol = Globals.GetColumnsIndex("warehouses");
            warehousesEmailAddressesCol = Globals.GetColumnsIndex("warehouses_email_addresses");
            warehousesContactNumbersCol = Globals.GetColumnsIndex("warehouses_numbers");
            warehousesTypeCol = Globals.GetColumnsIndex("warehouses_Type");


            Globals.refreshCb(GGroupCb, "warehouses_Type", "NameEn");

            ContactDGV.AutoGenerateColumns = false;

            if (conf == "add")
            {
                Text = "Add new Warehouse Wizerd";
                ((Control)EmailTP).Enabled = false;
                ((Control)ContactTP).Enabled = false;
                ((Control)Addresses).Enabled = false;
            }
            else
            {
                CancelBack.Visible = false;
                NextEnd.Text = "Done";
                Text = "Edit Warehouse Wizerd";
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
                        SQL = $"SELECT * FROM warehouses WHERE ID = {SelectedID}";
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                        {
                            dr.Read();
                            GNameEnTB.Text = dr.IsDBNull(warehousesCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            GNameArTB.Text = dr.IsDBNull(warehousesCol["NameAr"]) ? "" : dr.GetString("NameAr");
                            GGroupCb.SelectedItem = dr.IsDBNull(warehousesCol["TypeID"]) ? "" : Globals.GetStringById("NameEn", "warehouses_Type", dr.GetInt32("TypeID"));
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM warehouses_email_addresses WHERE UserID = {SelectedID}"))
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
                        SQL = $"SELECT warehouses_numbers.ID, ContactNumber, countries.Shortcut, contact_type.NameEn as ContactType FROM warehouses_numbers INNER JOIN countries ON warehouses_numbers.CountryID=countries.ID INNER JOIN contact_type ON warehouses_numbers.ContactTypeID=contact_type.ID WHERE UserID ={SelectedID};";
                        ContactDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
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
                        SQL = $"SELECT warehouses_addresses.ID, countries.NameEn as Country, cities.NameEn as City, District, Street, ZipCode, Description FROM warehouses_addresses INNER JOIN countries ON warehouses_addresses.CountryID = countries.ID INNER JOIN cities ON warehouses_addresses.CityID = cities.ID WHERE UserID = {SelectedID};";
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
            if (TapsPage.SelectedIndex == 0)
            {
                string SQL;
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                Globals.CleanTB(this.Controls);
                if (GNameArTB.Text == "" || GNameEnTB.Text == "")
                {
                    MessageBox.Show("Please fill all feilds");
                    return;
                }

                if (command == "edit" || SelectedID != 0)
                {
                    if (Globals.ifExist("warehouses", "UserName", GNameEnTB.Text, SelectedID))
                    {
                        MessageBox.Show("This Vat Number is alredy Exist");
                        return;
                    }
                    SQL = $"UPDATE warehouses SET UserName=@UserName NameEn=@NameEn, NameAr=@NameAr, BirthDate=@BirthDate, NationalNumber=@NationalNumber, TypeID=@TypeID, GenderID=@GenderID WHERE ID={SelectedID};";

                }
                else
                {

                    if (Globals.ifExist("warehouses", "UserName", GNameEnTB.Text))
                    {
                        MessageBox.Show("This Vat Number is alredy Exist");
                        return;
                    }

                    SQL = $"INSERT INTO warehouses (UserName, NameEn, NameAr, BirthDate, NationalNumber, TypeID, GenderID) VALUES(@UserName, @NameEn, @NameAr, @BirthDate, @NationalNumber, @TypeID, @GenderID);";

                }
                myPara.Add("@NameEn", GNameEnTB.Text);
                myPara.Add("@NameAr", GNameArTB.Text);
                myPara.Add("@TypeID", Globals.GetIdByString("warehouses_Type", "NameEn", GGroupCb.Text));


                Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                ((Control)EmailTP).Enabled = true;
                ((Control)ContactTP).Enabled = true;
                if (SelectedID == 0)
                    SelectedID = Globals.GetIdByString("warehouses", "NameEn", GNameEnTB.Text);

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
                AddEemail AddWindow = new AddEemail("edit", "warehouses_email_addresses", SelectedID, EmailsCBL.CheckedItems[0].ToString());
                AddWindow.ShowDialog();
                refreshTap();
            }
        }

        private void AddEmailB_Click(object sender, EventArgs e)
        {
            AddEemail AddWindow = new AddEemail("add", "warehouses_email_addresses", SelectedID);
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
                        Globals.DeleteValue("warehouses_email_addresses", "EmailAddress", item.ToString());
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


        private void AddTypeB_Click(object sender, EventArgs e)
        {
            DefaultsDGV2 window = new DefaultsDGV2("warehouses_Type");
            window.ShowDialog();
            Globals.refreshCb(GGroupCb, "warehouses_Type", "NameEn");
        }

    }
}
