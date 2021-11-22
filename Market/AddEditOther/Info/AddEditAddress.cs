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
        public int UserID;
        public int ID;
        public string command;
        public Dictionary<string, int> CountryCol = new Dictionary<string, int>();
        public Dictionary<string, int> CityCol = new Dictionary<string, int>();
        public Dictionary<string, int> tableCol = new Dictionary<string, int>();
        public AddEditAddress()
        {
            InitializeComponent();
        }

        public AddEditAddress(string cmd, string table, int selectedUser, int selectedAddr=0)
        {
            InitializeComponent();

            UserID= selectedUser;
            ID= selectedAddr;
            command = cmd;

            SQLtable = table;
            applyB.Text = command.ToUpper();
            Text = $"{command.ToUpper()} Wizerd";

            CountryCol = Globals.GetColumnsIndex("countries");
            CityCol = Globals.GetColumnsIndex("cities");
            tableCol = Globals.GetColumnsIndex(table);
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM countries;"))
                while (dr.Read())
                {
                    ContryCB.Items.Add(dr.IsDBNull(CountryCol["NameEN"]) ? "" : dr.GetString("NameEN"));
                }
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM cities;"))
                while (dr.Read())
                {
                    CityCB.Items.Add(dr.IsDBNull(CityCol["NameEN"]) ? "" : dr.GetString("NameEN"));
                }

            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE ID = @ID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@ID", ID);
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    ContryCB.SelectedIndex = dr.IsDBNull(tableCol["CountryID"]) ? 0 : int.Parse(dr.GetString("CountryID")) - 1;
                    CityCB.SelectedIndex = dr.IsDBNull(tableCol["CityID"]) ? 0 : int.Parse(dr.GetString("CityID")) - 1;
                    DistrictTB.Text = dr.IsDBNull(tableCol["District"]) ? "" : dr.GetString("District");
                    StreetTB.Text = dr.IsDBNull(tableCol["Street"]) ? "" : dr.GetString("Street");
                    ZipCodeTB.Text = dr.IsDBNull(tableCol["ZipCode"]) ? "" : dr.GetString("ZipCode");
                    DiscRTB.Text = dr.IsDBNull(tableCol["Description"]) ? "" : dr.GetString("Description");

                }
            }
        }

        private void applyB_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = "";

            if (DistrictTB.Text == "" || StreetTB.Text == "" ||  ZipCodeTB.Text == "" ||  DiscRTB.Text == "")
            {
                MessageBox.Show("Please fill the feilds");
                return;
            }

            if (command == "edit")
            {
                SQL = $"UPDATE {SQLtable} SET CountryID= @CountryID, CityID= @CityID, District= @District, Street= @Street, ZipCode= @ZipCode, Description= @Description WHERE AddressID = @ID";
                myPara.Add("@ID", ID);
            }
            else if (command == "add")
            {
                SQL = $@"INSERT INTO {SQLtable} (UserID, CountryID, CityID, District, Street, ZipCode, Description) VALUES(@UserID, @CountryID, @CityID, @District, @Street, @ZipCode, @Description);";
            }

            myPara.Add("@UserID", UserID);
            myPara.Add("@CountryID", Globals.GetID("CountryID", "countries", "CountryNameEN", ContryCB.Text));
            myPara.Add("@CityID", Globals.GetID("CityID", "cities", "CityNameEN", CityCB.Text));
            myPara.Add("@District", Globals.RmSpace(DistrictTB.Text));
            myPara.Add("@Street", Globals.RmSpace(StreetTB.Text));
            myPara.Add("@ZipCode", Globals.RmSpace(ZipCodeTB.Text));
            myPara.Add("@Description", Globals.RmSpace(DiscRTB.Text));

            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            this.Close();
        }
    }
}
