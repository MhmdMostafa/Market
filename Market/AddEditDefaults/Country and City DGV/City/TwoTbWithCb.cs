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
    public partial class TwoTbWithCb : MaterialSkin.Controls.MaterialForm
    {
        public static int ID;
        public static string SQLtable;
        public static string command;
        Dictionary<string, int> tableCol = new Dictionary<string, int>();
        Dictionary<string, int> CountryCol = new Dictionary<string, int>();
        public TwoTbWithCb()
        {
            InitializeComponent();
        }

        public TwoTbWithCb(string conf, string table, int SelectedId = 0)
        {
            InitializeComponent();
            ID = SelectedId;
            SQLtable = table;
            command = conf;
            string SQL;
            CountryCol = Globals.GetColumnsIndex("countries");
            tableCol = Globals.GetColumnsIndex(table);

            Text = $"{command.ToUpper()} Wizerd";
            AddEditBT.Text = command.ToUpper();

            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM countries;"))
                while (dr.Read())
                {
                    CountryCB.Items.Add(dr.IsDBNull(CountryCol["NameEn"]) ? "" : dr.GetString("NameEn"));
                }
            if (command == "edit")
            {
                SQL = $@"SELECT * FROM {SQLtable} WHERE ID={ID}";
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                {
                    dr.Read();
                    NameEnTB.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                    NameArTB.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                    CountryCB.SelectedIndex = dr.IsDBNull(tableCol["CountryID"]) ? 0 : int.Parse(dr.GetString("CountryID")) - 1;

                }
            }
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            string SQL;
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            if (NameEnTB.Text == "" || NameArTB.Text == "")
            {
                MessageBox.Show("Please fill all the Feilds");
                return;
            }
            if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text.ToUpper())) || Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text)))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (NameEn, NameAr, CountryID) VALUES(@NameEn, @NameAr, @CountryID);";

            }
            else
            {
                if (Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text.ToUpper()), ID) || Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text),ID))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"UPDATE {SQLtable} SET NameEn=@NameEn, NameAr=@NameAr, CountryID=@CountryID WHERE ID=@ID;";
                myPara.Add("@ID", ID);

            }

            myPara.Add("@NameEn", Globals.RmSpace(NameEnTB.Text.ToUpper()));
            myPara.Add("@NameAr", Globals.RmSpace(NameArTB.Text));
            myPara.Add("@CountryID", Globals.contactTypeCol("ID", "countries", "NameEn", CountryCB.Text));
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();
        }
    }
}
