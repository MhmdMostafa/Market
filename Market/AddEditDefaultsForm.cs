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
        public int SelctedID;
        public AddEditDefaultsForm()
        {
            InitializeComponent();
        }
        public AddEditDefaultsForm(bool conf, string table, int id = 0)
        {
            InitializeComponent();
            SelctedID = id;
            SQLtable = table;
            if (conf)
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

                    if (AddEditBT.Text == "Edit")
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
                    if (AddEditBT.Text == "Edit")
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

                    if (AddEditBT.Text == "Edit")
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
                    if (AddEditBT.Text == "Edit")
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
                    if (AddEditBT.Text == "Edit")
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
                    if (AddEditBT.Text == "Edit")
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
                    if (AddEditBT.Text == "Edit")
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
                    if (AddEditBT.Text == "Edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM emp_permissions WHERE PermissionID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.GetString("PermissionNameEN");
                            textBox2.Text = dr.GetString("PermissionNameAr");
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
            if (AddEditBT.Text == "ADD")
            {
                switch (SQLtable)
                {
                    //countries
                    case "countries":

                        SQL = @"INSERT INTO countries (ContinentID, CountryCallingCodeID, CountryNameEN, CountryNameAR, Shortcut) VALUES(@ContinentID, @CountryCallingCodeID, @CountryNameEN, @CountryNameAR, @Shortcut);";
                               
                                
                        myPara.Add("@ContinentID", Globals.GetID(SQLtable, "ContinentNameEN", comboBox1.Text, "ContinentID"));
                        myPara.Add("@CountryCallingCodeID", textBox3.Text);
                        myPara.Add("@CountryNameEN", textBox1.Text);
                        myPara.Add("@CountryNameAR", textBox2.Text);
                        myPara.Add("@Shortcut", textBox4.Text);
                        Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                            
                        break;

                    case "currencies":

                        break;

                    case "units_value":
                        
                        break;
                    case "products_groub":
                        
                        break;

                    case "products_type":
                       
                        break;

                    case "customer_groups":
                       
                        break;

                    case "emp_group":
                        
                        break;

                    case "emp_permissions":
                       
                        break;

                }
            }
            else
            {

            }
        }
    }
}
