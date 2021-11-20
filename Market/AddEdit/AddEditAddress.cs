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
    public partial class AddEditAddress : MaterialSkin.Controls.MaterialForm
    {

        public string SQLtable;
        public string[] OldInfo = new string[6];
        public int selectedID;
        public string command;
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddEditAddress()
        {
            InitializeComponent();
        }

        public AddEditAddress(string cmd, string table, int id)
        {
            InitializeComponent();

            selectedID = id;
            command = cmd;

            SQLtable = table;
            applyB.Text = command.ToUpper();
            Text = $"{command.ToUpper()} Wizerd";

            tableCol = Globals.GetColumnsIndex(table);

            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM countries;"))
                while (dr.Read())
                {
                    ContryCB.Items.Add(dr.IsDBNull(tableCol["ContinentNameEN"]) ? "" : dr.GetString("ContinentNameEN"));
                }

            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE AddressID = @AddressID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@AddressID", id);
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    ContryCB.SelectedIndex = dr.IsDBNull(tableCol["CountryID"]) ? 0 : int.Parse(dr.GetString("CountryID")) - 1;
                    OldInfo[1] = dr.GetString("CityID");
                    OldInfo[2] = dr.GetString("District");
                    OldInfo[3] = dr.GetString("Street");
                    OldInfo[4] = dr.GetString("ZipCode");
                    OldInfo[4] = dr.GetString("Description");

                }
            }
        }

        private void applyB_Click(object sender, EventArgs e)
        {

        }
    }
}
