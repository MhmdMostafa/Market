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
    public partial class For2TB : MaterialSkin.Controls.MaterialForm
    {
        string SQLtable;
        public For2TB()
        {
            InitializeComponent();
        }

        public For2TB(string table)
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
                case "cities":
                    SQL = $"SELECT ContactID, ContactNumber, countries.Shortcut, contact_type.ContactNameEN FROM suppliers_contact_numbers INNER JOIN countries ON suppliers_contact_numbers.CountryID=countries.CountryID INNER JOIN contact_type ON suppliers_contact_numbers.ContactTypeID=contact_type.ContactTypeID;";
                    
                    dataGridView.DataSource = Globals.myCrud.getDtPassSql(SQL);


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
