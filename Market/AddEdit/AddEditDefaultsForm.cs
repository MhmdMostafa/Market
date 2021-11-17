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
    public partial class AddEditDefaultsForm : MaterialSkin.Controls.MaterialForm
    {

        public string SQLtable;
        public string command;
        public int SelctedID;
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddEditDefaultsForm()
        {
            InitializeComponent();
        }
        public AddEditDefaultsForm(string conf, string table, int id = 0)
        {

            InitializeComponent();
            tableCol = Globals.GetColumnsIndex(table);
            SelctedID = id;
            SQLtable = table;
            command = conf;
            if (command == "add")
            {
                Text = "Add New";
                AddEditBT.Text = "ADD";

            }
            else
            {
                Text = "Edit";
                AddEditBT.Text = "Edit";
            }

            switch (SQLtable)
            {
                //countries
                case "countries":
                    Text += " Country";
                    label_1.Text = "Continent:";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    label_4.Text = "Calling code:";
                    label_5.Text = "Shortcut:";
                    using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM continents;"))
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr.IsDBNull(tableCol["ContinentNameEN"]) ? "" : dr.GetString("ContinentNameEN"));
                        }

                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM countries WHERE CountryID = {SelctedID}"))
                        {
                            dr.Read();
                            //there is something here i need to understand
                            comboBox1.SelectedIndex = int.Parse(dr.IsDBNull(tableCol["ContinentID"]) ? "" : dr.GetString("ContinentID")) - 1;
                            textBox1.Text = dr.IsDBNull(tableCol["CountryNameEN"]) ? "" : dr.GetString("CountryNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["CountryNameAR"]) ? "" : dr.GetString("CountryNameAR");
                            textBox3.Text = dr.IsDBNull(tableCol["CountryCallingCodeID"]) ? "" : dr.GetString("CountryCallingCodeID");
                            textBox4.Text = dr.IsDBNull(tableCol["Shortcut"]) ? "" : dr.GetString("Shortcut");
                        }

                    }
                    break;

                case "currencies":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;

                    Text += " Currency";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    label_4.Text = "Shortcut:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM currencies WHERE CurrencyID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["CurrencyNameEN"]) ? "" : dr.GetString("CurrencyNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["CurrencyNameAR"]) ? "" : dr.GetString("CurrencyNameAR");
                            textBox3.Text = dr.IsDBNull(tableCol["CurrencyShortCut"]) ? "" : dr.GetString("CurrencyShortCut");
                        }

                    }
                    break;

                case "units_value":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Unit Value";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    label_4.Text = "Shortcut:";

                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM units_value WHERE UnitValueID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["UnitValueNameEN"]) ? "" : dr.GetString("UnitValueNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["UnitValueNameAR"]) ? "" : dr.GetString("UnitValueNameAR");
                            textBox3.Text = dr.IsDBNull(tableCol["UnitsValueShortCut"]) ? "" : dr.GetString("UnitsValueShortCut");
                        }

                    }
                    break;
                case "products_groub":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Product Type";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM products_groub WHERE ProductGroubID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["ProductGroubNameEN"]) ? "" : dr.GetString("ProductGroubNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["ProductGroubNameAR"]) ? "" : dr.GetString("ProductGroubNameAR");
                        }

                    }
                    break;

                case "products_type":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Product Type";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM products_type WHERE ProductTypeID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["ProductTypeNameEN"]) ? "" : dr.GetString("ProductTypeNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["ProductTypeNameAR"]) ? "" : dr.GetString("ProductTypeNameAR");
                        }

                    }
                    break;

                case "customer_groups":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Customer Group";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM customer_groups WHERE CustomerGroupID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["CustomerGroupNameEN"]) ? "" : dr.GetString("CustomerGroupNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["CustomerGroupID"]) ? "" : dr.GetString("CustomerGroupID");
                        }

                    }
                    break;

                case "emp_group":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Emploee Group";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM emp_group WHERE EmpGroupID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["EmpGroupNameEN"]) ? "" : dr.GetString("EmpGroupNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["EmpGroupNameAR"]) ? "" : dr.GetString("EmpGroupNameAR");
                        }

                    }
                    break;

                case "emp_permissions":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Emploee Permission";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM emp_permissions WHERE PermissionID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["PermissionNameEN"]) ? "" : dr.GetString("PermissionNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["PermissionNameAr"]) ? "" : dr.GetString("PermissionNameAr");
                        }

                    }
                    break;

                case "invoice_type":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Emploee Permission";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM invoice_type WHERE InvoiceTypeID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["InvoiceTypeNameEN"]) ? "" : dr.GetString("InvoiceTypeNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["InvoiceTypeNameAR"]) ? "" : dr.GetString("InvoiceTypeNameAR");
                        }

                    }
                    break;
                case "contact_type":
                    label_1.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    textBox3.Visible = false;
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Emploee Permission";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM contact_type WHERE ContactTypeID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["ContactNameEN"]) ? "" : dr.GetString("ContactNameEN");
                            textBox2.Text = dr.IsDBNull(tableCol["ContactNameAR"]) ? "" : dr.GetString("ContactNameAR");
                        }

                    }
                    break;

            }
            Text += " Wizerd";
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL;

            switch (SQLtable)
            {
                //countries
                case "countries":

                    if (command == "add")
                        SQL = @"INSERT INTO countries (ContinentID, CountryCallingCodeID, CountryNameEN, CountryNameAR, Shortcut) VALUES(@ContinentID, @CountryCallingCodeID, @CountryNameEN, @CountryNameAR, @Shortcut);";
                    else
                        SQL = $@"UPDATE countries SET ContinentID=@ContinentID, CountryCallingCodeID=@CountryCallingCodeID, CountryNameEN= @CountryNameEN, CountryNameAR=@CountryNameAR, Shortcut=@Shortcut WHERE CountryID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }

                    myPara.Add("@ContinentID", Globals.GetID("ContinentID", "continents", "ContinentNameEN", comboBox1.Text));
                    myPara.Add("@CountryCallingCodeID", Globals.RmSpace(textBox3.Text));
                    myPara.Add("@CountryNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@CountryNameAR", Globals.RmSpace(textBox2.Text));
                    myPara.Add("@Shortcut", Globals.RmSpace(textBox4.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "currencies":
                    if (command == "add")
                        SQL = @"INSERT INTO currencies (CurrencyNameEN, CurrencyNameAR, CurrencyShortCut) VALUES(@CurrencyNameEN, @CurrencyNameAR, @CurrencyShortCut);";
                    else
                        SQL = $@"UPDATE currencies SET CurrencyNameEN=@CurrencyNameEN, CurrencyNameAR=@CurrencyNameAR, CurrencyShortCut=@CurrencyShortCut WHERE CurrencyID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@CurrencyNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@CurrencyNameAR", Globals.RmSpace(textBox2.Text));
                    myPara.Add("@CurrencyShortCut", Globals.RmSpace(textBox3.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "units_value":
                    if (command == "add")
                        SQL = @"INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut) VALUES(@UnitValueNameEN, @UnitValueNameAR, @UnitsValueShortCut);";
                    else
                        SQL = $@"UPDATE units_value SET UnitValueNameEN=@UnitValueNameEN, UnitValueNameAR=@UnitValueNameAR, UnitsValueShortCut=@UnitsValueShortCut WHERE CurrencyID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@UnitValueNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@UnitValueNameAR", Globals.RmSpace(textBox2.Text));
                    myPara.Add("@UnitsValueShortCut", Globals.RmSpace(textBox3.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;
                case "products_groub":
                    if (command == "add")
                        SQL = @"INSERT INTO products_groub (ProductGroubNameEN, ProductGroubNameAR) VALUES(@ProductGroubNameEN, @ProductGroubNameAR);";
                    else
                        SQL = $@"UPDATE products_groub SET ProductGroubNameEN=@ProductGroubNameEN, ProductGroubNameAR=@ProductGroubNameAR WHERE ProductGroubID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@ProductGroubNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@ProductGroubNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "products_type":
                    if (command == "add")
                        SQL = @"INSERT INTO products_type (ProductTypeNameEN, ProductTypeNameAR) VALUES(@ProductTypeNameEN, @ProductTypeNameAR);";
                    else
                        SQL = $@"UPDATE products_type SET ProductTypeNameEN=@ProductTypeNameEN, ProductTypeNameAR=@ProductTypeNameAR WHERE ProductTypeID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@ProductTypeNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@ProductTypeNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "customer_groups":
                    if (command == "add")
                        SQL = @"INSERT INTO customer_groups (CustomerGroupNameEN, CustomerGroupNameAR) VALUES(@CustomerGroupNameEN, @CustomerGroupNameAR);";
                    else
                        SQL = $@"UPDATE customer_groups SET CustomerGroupNameEN=@CustomerGroupNameEN, CustomerGroupNameAR=@CustomerGroupNameAR WHERE CustomerGroupID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@CustomerGroupNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@CustomerGroupNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "emp_group":
                    if (command == "add")
                        SQL = @"INSERT INTO emp_group (EmpGroupNameEN, EmpGroupNameAR) VALUES(@EmpGroupNameEN, @EmpGroupNameAR);";
                    else
                        SQL = $@"UPDATE emp_group SET EmpGroupNameEN=@EmpGroupNameEN, EmpGroupNameAR=@EmpGroupNameAR WHERE EmpGroupID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@EmpGroupNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@EmpGroupNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "emp_permissions":
                    if (command == "add")
                        SQL = @"INSERT INTO emp_permissions (PermissionNameEN, PermissionNameAr) VALUES(@PermissionNameEN, @PermissionNameAr);";
                    else
                        SQL = $@"UPDATE emp_permissions SET PermissionNameEN=@PermissionNameEN, PermissionNameAr=@PermissionNameAr WHERE PermissionID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@PermissionNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@PermissionNameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "invoice_type":
                    if (command == "add")
                        SQL = @"INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR) VALUES(@InvoiceTypeNameEN, @InvoiceTypeNameAR);";
                    else
                        SQL = $@"UPDATE invoice_type SET InvoiceTypeNameEN=@InvoiceTypeNameEN, InvoiceTypeNameAR=@InvoiceTypeNameAR WHERE InvoiceTypeID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@InvoiceTypeNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@InvoiceTypeNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "contact_type":
                    if (command == "add")
                        SQL = @"INSERT INTO contact_type (ContactNameEN, ContactNameAR) VALUES(@ContactNameEN, @ContactNameAR);";
                    else
                        SQL = $@"UPDATE contact_type SET ContactNameEN=@ContactNameEN, ContactNameAR=@ContactNameAR WHERE ContactTypeID={SelctedID};";
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    myPara.Add("@ContactNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@ContactNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

            }


        }
    }
}
