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
        public int UserID;
        public int contactId;
        public string command;
        public Dictionary<string, int> countryCol = new Dictionary<string, int>();
        public Dictionary<string, int> contactTypeCol = new Dictionary<string, int>();
        Dictionary<string, int> tableCol = new Dictionary<string, int>();

        public AddContact()
        {
            InitializeComponent();
        }

        public AddContact(string cmd, string table, int id, int phID = 0)
        {
            InitializeComponent();
            UserID = id;
            contactId = phID;
            command = cmd;
            SQLtable = table;
            countryCol = Globals.GetColumnsIndex("countries");
            contactTypeCol = Globals.GetColumnsIndex("contact_type");
            tableCol = Globals.GetColumnsIndex(table);
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM countries;"))
                while (dr.Read())
                    CountryCB.Items.Add(dr.IsDBNull(countryCol["CallingCode"]) ? "" : dr.GetString("CallingCode"));

            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM contact_type;"))
                while (dr.Read())
                    typeCB.Items.Add(dr.IsDBNull(contactTypeCol["NameEn"]) ? "" : dr.GetString("NameEn"));

            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE ID = @ID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@ID", (contactId));
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    CountryCB.SelectedItem = dr.IsDBNull(tableCol["CountryID"]) ? "" : Globals.GetStringById("CallingCode", "countries", dr.GetInt32("CountryID"));
                    typeCB.SelectedItem = dr.IsDBNull(tableCol["ContactTypeID"]) ? "" : Globals.GetStringById("NameEn", "contact_type", dr.GetInt32("ContactTypeID"));
                    PhoneTB.Text = dr.IsDBNull(tableCol["ContactNumber"]) ? "" : dr.GetString("ContactNumber");
                }
            }

            Text = $"{cmd} Wizerd";
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
                if (Globals.ifExist(SQLtable, "ContactNumber", PhoneTB.Text, contactId))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                    SQL = $"UPDATE {SQLtable} SET CountryID= @CountryID, ContactTypeID= @ContactTypeID, ContactNumber= @ContactNumber WHERE ID = @ID";

                myPara.Add("@ID", contactId);
            }
            else if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "ContactNumber", PhoneTB.Text))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (UserID, CountryID, ContactTypeID, ContactNumber) VALUES(@UserID, @CountryID, @ContactTypeID, @ContactNumber);";

            }

            myPara.Add("@UserID", UserID);
            myPara.Add("@CountryID", Globals.GetIdByString("ID", "countries", "CallingCode", CountryCB.Text));
            myPara.Add("@ContactTypeID", Globals.GetIdByString("ID", "contact_type", "NameEn", typeCB.Text));
            myPara.Add("@ContactNumber", PhoneTB.Text);
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            this.Close();
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
