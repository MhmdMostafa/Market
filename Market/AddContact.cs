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
        public string phoneOld;
        public int selectedID;
        public string command;
        public Dictionary<string, int> CountryIDCol = new Dictionary<string, int>();
        public Dictionary<string, int> ContactTypeIDCol = new Dictionary<string, int>();

        public AddContact()
        {
            InitializeComponent();
        }

        public AddContact(string cmd, string table, int id, string ph = "")
        {
            InitializeComponent();
            phoneOld = ph;
            selectedID = id;
            command = cmd;
            SQLtable = table;
            CountryIDCol = Globals.GetColumnsIndex("countries");
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM countries;"))
                while (dr.Read())
                {
                    CountryCB.Items.Add(dr.IsDBNull(CountryIDCol["CountryCallingCodeID"]) ? "" : dr.GetString("CountryCallingCodeID"));
                }

            ContactTypeIDCol = Globals.GetColumnsIndex("contact_type");
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM contact_type;"))
                while (dr.Read())
                {
                    typeCB.Items.Add(dr.IsDBNull(ContactTypeIDCol["ContactNameEN"]) ? "" : dr.GetString("ContactNameEN"));
                }

            
            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE ContactNumber = @ContactNumberOld AND UserID=@UserID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@UserID", selectedID);
                myPara.Add("@ContactNumberOld", Globals.RmSpace(phoneOld));
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    CountryCB.SelectedIndex = int.Parse(dr.IsDBNull(CountryIDCol["CountryID"]) ? "" : dr.GetString("CountryID")) - 1;
                    typeCB.SelectedIndex = int.Parse(dr.IsDBNull(ContactTypeIDCol["ContactTypeID"]) ? "" : dr.GetString("ContactTypeID")) - 1;
                    PhoneTB.Text = phoneOld;
                }
            }
            
            
            applyB.Text = cmd;
            


        }

        private void applyB_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = "";

            if (PhoneTB.Text == "")
            {
                MessageBox.Show("Please use valid email");
                return;
            }

            if (command == "edit")
            {
                SQL = $"UPDATE {SQLtable} SET CountryID= @CountryID, ContactTypeID= @ContactTypeID, ContactNumber= @ContactNumber WHERE ContactNumber = @ContactNumberOld AND UserID=@UserID";
                
                myPara.Add("@ContactNumberOld", Globals.RmSpace(phoneOld));
            }
            else if (command == "add")
            {
                SQL = $@"INSERT INTO {SQLtable} (UserID, CountryID, ContactTypeID, ContactNumber) VALUES(@UserID, @CountryID, @ContactTypeID, @ContactNumber);";

            }



            DialogResult d = MessageBox.Show("are you sure", command.ToUpper(), MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                myPara.Add("@UserID", selectedID);
                myPara.Add("@CountryID", Globals.GetID("CountryID", "countries", "CountryCallingCodeID", CountryCB.Text));
                myPara.Add("@ContactTypeID", Globals.GetID("ContactTypeID", "contact_type", "ContactNameEN", typeCB.Text));
                myPara.Add("@ContactNumber", PhoneTB.Text);
                Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
                this.Close();
            }
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
