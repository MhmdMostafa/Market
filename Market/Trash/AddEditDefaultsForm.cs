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
        public Dictionary<string, int> ContinentCol = new Dictionary<string, int>();
        public Dictionary<string, int> CountryCol = new Dictionary<string, int>();
        public AddEditDefaultsForm()
        {
            InitializeComponent();
        }
        public AddEditDefaultsForm(string conf, string table, int id = 0)
        {

            InitializeComponent();
            tableCol = Globals.GetColumnsIndex(table);
            ContinentCol = Globals.GetColumnsIndex("continents");
            CountryCol = Globals.GetColumnsIndex("countries");

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
                            comboBox1.Items.Add(dr.IsDBNull(ContinentCol["NameEn"]) ? "" : dr.GetString("NameEn"));
                        }

                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM countries WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            //there is something here i need to understand
                            comboBox1.SelectedIndex = dr.IsDBNull(tableCol["ContinentID"]) ? 0 : int.Parse(dr.GetString("ContinentID")) - 1;
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                            textBox3.Text = dr.IsDBNull(tableCol["CallingCode"]) ? "" : dr.GetString("CallingCode");
                            textBox4.Text = dr.IsDBNull(tableCol["Shortcut"]) ? "" : dr.GetString("Shortcut");
                        }

                    }
                    break;
                case "cities":
                    label_4.Visible = false;
                    textBox4.Visible = false;
                    label_5.Visible = false;
                    textBox3.Visible = false;

                    Text += " City";
                    label_1.Text = "Country:";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM countries;"))
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn"));
                        }

                    if (command == "edit")
                    {
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM cities WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            //there is something here i need to understand
                            comboBox1.SelectedIndex = dr.IsDBNull(tableCol["NameEn"]) ? 0 : int.Parse(dr.GetString("NameEn")) - 1;
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM currencies WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM units_value WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                            textBox3.Text = dr.IsDBNull(tableCol["Shortcut"]) ? "" : dr.GetString("Shortcut");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM products_groub WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM products_type WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM emp_group WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM emp_permissions WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM invoice_type WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                        using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT * FROM contact_type WHERE ID = {SelctedID}"))
                        {
                            dr.Read();
                            textBox1.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                            textBox2.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
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
                case "countries":
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("countries", "Shortcut", Globals.RmSpace(textBox4.Text)) || Globals.ifExist("countries", "CallingCode", Globals.RmSpace(textBox3.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO countries (ContinentID, CallingCode, NameEn, NameAr, Shortcut) VALUES(@ContinentID, @CallingCode, @NameEn, @NameAr, @Shortcut);";
                    }
                    else
                        SQL = $@"UPDATE countries SET ContinentID=@ContinentID, CallingCode=@CallingCode, NameEn= @NameEn, NameAr=@NameAr, Shortcut=@Shortcut WHERE ID={SelctedID};";

                    myPara.Add("@ContinentID", Globals.GetIdByString("ContinentID", "continents", "NameEn", comboBox1.Text));
                    myPara.Add("@CallingCode", Globals.RmSpace(textBox3.Text));
                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    myPara.Add("@Shortcut", Globals.RmSpace(textBox4.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "cities":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("cities", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("cities", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO cities (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE cities SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "currencies":
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("currencies", "CurrencyShortCut", Globals.RmSpace(textBox4.Text)) || Globals.ifExist("currencies", "NameEn", Globals.RmSpace(textBox1.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO currencies (NameEn, NameAr, CurrencyShortCut) VALUES(@NameEn, @NameAr, @CurrencyShortCut);";
                    }
                    else
                        SQL = $@"UPDATE currencies SET NameEn=@NameEn, NameAr=@NameAr, CurrencyShortCut=@CurrencyShortCut WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    myPara.Add("@CurrencyShortCut", Globals.RmSpace(textBox3.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "units_value":
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("units_value", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("units_value", "Shortcut", Globals.RmSpace(textBox3.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO units_value (NameEn, NameAr, Shortcut) VALUES(@NameEn, @NameAr, @Shortcut);";
                    }
                    else
                        SQL = $@"UPDATE units_value SET NameEn=@NameEn, NameAr=@NameAr, Shortcut=@Shortcut WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    myPara.Add("@Shortcut", Globals.RmSpace(textBox3.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "products_groub":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("products_groub", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("products_groub", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO products_groub (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE products_groub SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";
                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "products_type":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("products_type", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("products_type", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                        }
                        SQL = @"INSERT INTO products_type (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE products_type SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "customer_groups":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("customer_groups", "CustomerGroupNameEN", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("customer_groups", "CustomerGroupNameAR", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO customer_groups (CustomerGroupNameEN, CustomerGroupNameAR) VALUES(@CustomerGroupNameEN, @CustomerGroupNameAR);";
                    }
                    else
                        SQL = $@"UPDATE customer_groups SET CustomerGroupNameEN=@CustomerGroupNameEN, CustomerGroupNameAR=@CustomerGroupNameAR WHERE CustomerGroupID={SelctedID};";


                    myPara.Add("@CustomerGroupNameEN", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@CustomerGroupNameAR", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                    break;

                case "emp_group":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("emp_group", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("emp_group", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO emp_group (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE emp_group SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "emp_permissions":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("emp_permissions", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("emp_permissions", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                        SQL = @"INSERT INTO emp_permissions (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE emp_permissions SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "invoice_type":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("invoice_type", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("invoice_type", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                            SQL = @"INSERT INTO invoice_type (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE invoice_type SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";

                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

                case "contact_type":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    if (command == "add")
                    {
                        if (Globals.ifExist("contact_type", "NameEn", Globals.RmSpace(textBox1.Text)) || Globals.ifExist("contact_type", "NameAr", Globals.RmSpace(textBox2.Text)))
                        {
                            MessageBox.Show("Entry is alredy exist");
                            return;
                        }
                            SQL = @"INSERT INTO contact_type (NameEn, NameAr) VALUES(@NameEn, @NameAr);";
                    }
                    else
                        SQL = $@"UPDATE contact_type SET NameEn=@NameEn, NameAr=@NameAr WHERE ID={SelctedID};";

                    MessageBox.Show("Entry is alredy exist");
                    myPara.Add("@NameEn", Globals.RmSpace(textBox1.Text));
                    myPara.Add("@NameAr", Globals.RmSpace(textBox2.Text));
                    Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                    break;

            }


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;

            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
