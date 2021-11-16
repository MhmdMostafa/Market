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
        public AddEditDefaultsForm()
        {
            InitializeComponent();
        }
        public AddEditDefaultsForm(string conf, string table, int id = 0)
        {
            InitializeComponent();
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
                            comboBox1.Items.Add(dr.GetString("ContinentNameEN"));
                        }

                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM countries WHERE CountryID = {SelctedID}"))
                        {
                            dr.Read();
                            comboBox1.SelectedIndex=int.Parse(dr.GetString("ContinentID")) -1;
                            textBox1.Text= dr.GetString("CountryNameEN");
                            textBox2.Text = dr.GetString("CountryNameAR");
                            textBox3.Text = dr.GetString("CountryCallingCodeID");
                            textBox4.Text = dr.GetString("Shortcut");
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
                            textBox1.Text = dr.GetString("CurrencyNameEN");
                            textBox2.Text = dr.GetString("CurrencyNameAR");
                            textBox3.Text = dr.GetString("CurrencyShortCut");
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
                            textBox1.Text = dr.GetString("UnitValueNameEN");
                            textBox2.Text = dr.GetString("UnitValueNameAR");
                            textBox3.Text = dr.GetString("UnitsValueShortCut");
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
                            textBox1.Text = dr.GetString("ProductGroubNameEN");
                            textBox2.Text = dr.GetString("ProductGroubNameAR");
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
                            textBox1.Text = dr.GetString("ProductTypeNameEN");
                            textBox2.Text = dr.GetString("ProductTypeNameAR");
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
                            textBox1.Text = dr.GetString("CustomerGroupNameEN");
                            textBox2.Text = dr.GetString("CustomerGroupID");
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
                            textBox1.Text = dr.GetString("EmpGroupNameEN");
                            textBox2.Text = dr.GetString("EmpGroupNameAR");
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
                            textBox1.Text = dr.GetString("PermissionNameEN");
                            textBox2.Text = dr.GetString("PermissionNameAr");
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
                            textBox1.Text = dr.GetString("InvoiceTypeNameEN");
                            textBox2.Text = dr.GetString("InvoiceTypeNameAR");
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
                            textBox1.Text = dr.GetString("ContactNameEN");
                            textBox2.Text = dr.GetString("ContactNameAR");
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
            if (command == "add")
            {
                switch (SQLtable)
                {
                    //countries
                    case "countries":

                        SQL = @"INSERT INTO countries (ContinentID, CountryCallingCodeID, CountryNameEN, CountryNameAR, Shortcut) VALUES(@ContinentID, @CountryCallingCodeID, @CountryNameEN, @CountryNameAR, @Shortcut);";
                        myPara.Add("@ContinentID", Globals.GetID("ContinentID", "continents", "ContinentNameEN", comboBox1.Text));
                        myPara.Add("@CountryCallingCodeID", Globals.RmSpace(textBox3.Text));
                        myPara.Add("@CountryNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@CountryNameAR", Globals.RmSpace(textBox2.Text));
                        myPara.Add("@Shortcut", Globals.RmSpace(textBox4.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "currencies":
                        SQL = @"INSERT INTO currencies (CurrencyNameEN, CurrencyNameAR, CurrencyShortCut) VALUES(@CurrencyNameEN, @CurrencyNameAR, @CurrencyShortCut);";
                        myPara.Add("@CurrencyNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@CurrencyNameAR", Globals.RmSpace(textBox2.Text));
                        myPara.Add("@CurrencyShortCut", Globals.RmSpace(textBox3.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "units_value":
                        SQL = @"INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut) VALUES(@UnitValueNameEN, @UnitValueNameAR, @UnitsValueShortCut);";
                        myPara.Add("@UnitValueNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@UnitValueNameAR", Globals.RmSpace(textBox2.Text));
                        myPara.Add("@UnitsValueShortCut", Globals.RmSpace(textBox3.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;
                    case "products_groub":
                        SQL = @"INSERT INTO products_groub (ProductGroubNameEN, ProductGroubNameAR) VALUES(@ProductGroubNameEN, @ProductGroubNameAR);";
                        myPara.Add("@ProductGroubNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@ProductGroubNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "products_type":
                        SQL = @"INSERT INTO products_type (ProductTypeNameEN, ProductTypeNameAR) VALUES(@ProductTypeNameEN, @ProductTypeNameAR);";
                        myPara.Add("@ProductTypeNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@ProductTypeNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "customer_groups":
                        SQL = @"INSERT INTO customer_groups (CustomerGroupNameEN, CustomerGroupNameAR) VALUES(@CustomerGroupNameEN, @CustomerGroupNameAR);";
                        myPara.Add("@CustomerGroupNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@CustomerGroupNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "emp_group":
                        SQL = @"INSERT INTO emp_group (EmpGroupNameEN, EmpGroupNameAR) VALUES(@EmpGroupNameEN, @EmpGroupNameAR);";
                        myPara.Add("@EmpGroupNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@EmpGroupNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "emp_permissions":
                        SQL = @"INSERT INTO emp_permissions (PermissionNameEN, PermissionNameAr) VALUES(@PermissionNameEN, @PermissionNameAr);";
                        myPara.Add("@PermissionNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@PermissionNameAr", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "invoice_type":
                        SQL = @"INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR) VALUES(@InvoiceTypeNameEN, @InvoiceTypeNameAR);";
                        myPara.Add("@InvoiceTypeNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@InvoiceTypeNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "contact_type":
                        SQL = @"INSERT INTO contact_type (ContactNameEN, ContactNameAR) VALUES(@ContactNameEN, @ContactNameAR);";
                        myPara.Add("@ContactNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@ContactNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                }
            }
            else
            {
                switch (SQLtable)
                {
                    //countries
                    case "countries":

                        SQL = $@"UPDATE countries SET ContinentID=@ContinentID, CountryCallingCodeID=@CountryCallingCodeID, CountryNameEN= @CountryNameEN, CountryNameAR=@CountryNameAR, Shortcut=@Shortcut WHERE CountryID={SelctedID};";
                        myPara.Add("@ContinentID", Globals.GetID("ContinentID","continents", "ContinentNameEN", comboBox1.Text ));
                        myPara.Add("@CountryCallingCodeID", Globals.RmSpace(textBox3.Text));
                        myPara.Add("@CountryNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@CountryNameAR", Globals.RmSpace(textBox2.Text));
                        myPara.Add("@Shortcut", Globals.RmSpace(textBox4.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "currencies":
                        SQL = $@"UPDATE currencies SET CurrencyNameEN=@CurrencyNameEN, CurrencyNameAR=@CurrencyNameAR, CurrencyShortCut=@CurrencyShortCut WHERE CurrencyID={SelctedID};";
                        myPara.Add("@CurrencyNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@CurrencyNameAR", Globals.RmSpace(textBox2.Text));
                        myPara.Add("@CurrencyShortCut", Globals.RmSpace(textBox3.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "units_value":
                        SQL = $@"UPDATE units_value SET UnitValueNameEN=@UnitValueNameEN, UnitValueNameAR=@UnitValueNameAR, UnitsValueShortCut=@UnitsValueShortCut WHERE CurrencyID={SelctedID};";
                        myPara.Add("@UnitValueNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@UnitValueNameAR", Globals.RmSpace(textBox2.Text));
                        myPara.Add("@UnitsValueShortCut", Globals.RmSpace(textBox3.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;
                    case "products_groub":
                        SQL = $@"UPDATE products_groub SET ProductGroubNameEN=@ProductGroubNameEN, ProductGroubNameAR=@ProductGroubNameAR WHERE ProductGroubID={SelctedID};";
                        myPara.Add("@ProductGroubNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@ProductGroubNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "products_type":
                        SQL = $@"UPDATE products_type SET ProductTypeNameEN=@ProductTypeNameEN, ProductTypeNameAR=@ProductTypeNameAR WHERE ProductTypeID={SelctedID};";
                        myPara.Add("@ProductTypeNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@ProductTypeNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "customer_groups":
                        SQL = $@"UPDATE customer_groups SET CustomerGroupNameEN=@CustomerGroupNameEN, CustomerGroupNameAR=@CustomerGroupNameAR WHERE CustomerGroupID={SelctedID};";
                        myPara.Add("@CustomerGroupNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@CustomerGroupNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "emp_group":
                        SQL = $@"UPDATE emp_group SET EmpGroupNameEN=@EmpGroupNameEN, EmpGroupNameAR=@EmpGroupNameAR WHERE EmpGroupID={SelctedID};";
                        myPara.Add("@EmpGroupNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@EmpGroupNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "emp_permissions":
                        SQL = $@"UPDATE emp_permissions SET PermissionNameEN=@PermissionNameEN, PermissionNameAr=@PermissionNameAr WHERE PermissionID={SelctedID};";
                        myPara.Add("@PermissionNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@PermissionNameAr", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "invoice_type":
                        SQL = $@"UPDATE invoice_type SET InvoiceTypeNameEN=@InvoiceTypeNameEN, InvoiceTypeNameAR=@InvoiceTypeNameAR WHERE InvoiceTypeID={SelctedID};";
                        myPara.Add("@InvoiceTypeNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@InvoiceTypeNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                    case "contact_type":
                        SQL = $@"UPDATE contact_type SET ContactNameEN=@ContactNameEN, ContactNameAR=@ContactNameAR WHERE ContactTypeID={SelctedID};";
                        myPara.Add("@ContactNameEN", Globals.RmSpace(textBox1.Text));
                        myPara.Add("@ContactNameAR", Globals.RmSpace(textBox2.Text));
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                        break;

                }
            }
        }
    }
}
