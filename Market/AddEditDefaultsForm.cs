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
        public int command;
        public string SQLtable;
        
        public AddEditDefaultsForm()
        {
            InitializeComponent();
        }
        public AddEditDefaultsForm(bool conf,string table)
        {
            InitializeComponent();
            SQLtable = table;
            if (conf)
            {
                Text = "Add New";
                AddEditBT.Text = "ADD";
                command = 1;
            }
            else
            {
                Text = "Edit";
                AddEditBT.Text = "Edit";
                command = 2;
            }

            switch (table)
            {
                //countries
                case "countries":
                    Text += " Country";
                    label_1.Text = "Continent:";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    label_4.Text = "Calling code:";
                    label_5.Text = "Shortcut:";
                    MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM continents");
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr.GetString("ContinentNameEN"));
                    }
                    break;
                case "currencies":
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    Text += " Currency";
                    label_1.Text = "Country:";
                    label_2.Text = "Name English:";
                    label_3.Text = "Name Arabic:";
                    label_4.Text = "Shortcut:";
                    break;
                case "units_value":
                    label_5.Visible = false;
                    textBox4.Visible = false;
                    comboBox1.Visible = false;
                    label_4.Visible = false;
                    Text += " Unit Value";
                    label_1.Text = "Name English:";//textbox3
                    textBox3.Location = new System.Drawing.Point(201, 12);
                    label_2.Text = "Name Arabic:";//textbox1
                    label_3.Text = "Shortcut:"; //textbox2
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
                    break;

            }
            Text += " Wizerd";



        }

        

        
    }
}
