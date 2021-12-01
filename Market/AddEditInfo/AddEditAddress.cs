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

        public AddEditAddress(string cmd, string table, int selectedUser, int selectedAddr = 0)
        {
            InitializeComponent();

            UserID = selectedUser;
            ID = selectedAddr;
            command = cmd;

            SQLtable = table;
            applyB.Text = command.ToUpper();
            Text = $"{command.ToUpper()} Wizerd";

            CountryCol = Globals.GetColumnsIndex("countries");
            CityCol = Globals.GetColumnsIndex("cities");
            tableCol = Globals.GetColumnsIndex(table);

            Globals.refreshCb(ContryCB, "countries", "NameEn");
            Globals.refreshCb(CityCB, "cities", "NameEn");

            if (command == "edit")
            {
                string SQL = $@"SELECT * FROM {table} WHERE ID = @ID;";
                Dictionary<string, object> myPara = new Dictionary<string, object>();
                myPara.Add("@ID", ID);
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSqlDic(SQL, myPara))
                {
                    dr.Read();
                    ContryCB.SelectedItem = dr.IsDBNull(tableCol["CountryID"]) ? "" : Globals.GetStringById("NameEn", "countries", dr.GetInt32("CountryID"));
                    CityCB.SelectedItem = dr.IsDBNull(tableCol["CityID"]) ? "" : Globals.GetStringById("NameEn", "cities", dr.GetInt32("CityID"));
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
            Globals.CleanTB(this.Controls);
            if (DistrictTB.Text == "" || StreetTB.Text == "" || ZipCodeTB.Text == "" || DiscRTB.Text == "")
            {
                MessageBox.Show("Please fill the feilds");
                return;
            }

            if (command == "edit")
            {
                SQL = $"UPDATE {SQLtable} SET CountryID= @CountryID, CityID= @CityID, District= @District, Street= @Street, ZipCode= @ZipCode, Description= @Description WHERE ID = @ID";
                myPara.Add("@ID", ID);
            }
            else if (command == "add")
            {
                SQL = $@"INSERT INTO {SQLtable} (UserID, CountryID, CityID, District, Street, ZipCode, Description) VALUES(@UserID, @CountryID, @CityID, @District, @Street, @ZipCode, @Description);";
            }

            myPara.Add("@UserID", UserID);
            myPara.Add("@CountryID", Globals.GetIdByString("countries", "NameEn", ContryCB.Text));
            myPara.Add("@CityID", Globals.GetIdByString("cities", "NameEn", CityCB.Text));
            myPara.Add("@District", DistrictTB.Text);
            myPara.Add("@Street", StreetTB.Text);
            myPara.Add("@ZipCode", ZipCodeTB.Text);
            myPara.Add("@Description", DiscRTB.Text);

            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done");
            this.Close();
        }

        private void AddCountryB_Click(object sender, EventArgs e)
        {
            CountryDGV window = new CountryDGV("countries");
            window.ShowDialog();
            Globals.refreshCb(ContryCB, "countries", "NameEn");
        }

        private void AddCityB_Click(object sender, EventArgs e)
        {
            CityDGV window = new CityDGV("cities");
            window.ShowDialog();
            Globals.refreshCb(CityCB, "cities", "NameEn");
        }
    }
}
