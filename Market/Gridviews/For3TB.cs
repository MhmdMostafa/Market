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
using System.Data;

namespace Market
{
    public partial class For3TB : MaterialSkin.Controls.MaterialForm
    {
        string SQLtable;
        public For3TB()
        {
            InitializeComponent();
        }

        public For3TB(string table)
        {
            InitializeComponent();
            SQLtable = table;
        }

        private void refreshTap()
        {
            string SQL;
            SQL = $"SELECT ContactID, ContactNumber, countries.Shortcut, contact_type.ContactNameEN FROM suppliers_contact_numbers INNER JOIN countries ON suppliers_contact_numbers.CountryID=countries.CountryID INNER JOIN contact_type ON suppliers_contact_numbers.ContactTypeID=contact_type.ContactTypeID;";
            dataGridView.DataSource = Globals.myCrud.getDtPassSql(SQL);

            switch (SQLtable)
            {
                case "countries":
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    

                    break;

                case "cities":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    

                    break;

                case "currencies":
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                   

                    break;

                case "units_value":
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                   

                    break;

                case "products_groub":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    
                    break;

                case "products_type":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    
                    break;

                case "customer_groups":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                   
                    break;

                case "emp_group":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                   

                    break;

                case "emp_permissions":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    
                    break;

                case "invoice_type":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                   
                    break;

                case "contact_type":
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill the feilds");
                        return;
                    }
                    break;

            }


        }
    }
}
