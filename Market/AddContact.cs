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
    public partial class AddContact : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable;
        public string phone;
        public int selectedID;
        public string command;
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddContact()
        {
            InitializeComponent();
        }

        public AddContact(string cmd, string table, int id, string ph = "")
        {
            InitializeComponent();
            phone = ph;
            selectedID = id;
            command = cmd;

            tableCol = Globals.GetColumnsIndex("countries");

            PhoneTB.Text = ph;
            applyB.Text = cmd;
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM continents;"))
                while (dr.Read())
                {
                    typeCB.Items.Add(dr.IsDBNull(tableCol["ContinentNameEN"]) ? "" : dr.GetString("ContinentNameEN"));
                }


        }

        private void applyB_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;

            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || PhoneTB.Text.Length > 9)
            {
                e.Handled = true;
            }
        }
    }
}
