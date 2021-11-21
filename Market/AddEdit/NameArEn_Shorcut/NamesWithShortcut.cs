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

    public partial class NamesWithShortcut : MaterialSkin.Controls.MaterialForm
    {
        public static int ID;
        public static string SQLtable;
        public static string command;
        public static string tempEn;
        public static string tempAr;
        public static string tempShortcut;
        Dictionary<string, int> tableCol = new Dictionary<string, int>();

        public NamesWithShortcut()
        {
            InitializeComponent();
        }

        public NamesWithShortcut(string conf, string table, int SelectedId = 0)
        {
            InitializeComponent();
            ID = SelectedId;
            SQLtable = table;
            command = conf;
            string SQL;
            Text = $"{command.ToUpper()} Wizerd";
            AddEditBT.Text = command.ToUpper();
            tableCol = Globals.GetColumnsIndex(table);
            if (command == "edit")
            {
                SQL = $@"SELECT * FROM {SQLtable} WHERE ID={ID}";
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                {
                    dr.Read();
                    NameEnTB.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                    NameArTB.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                    ShortcutTB.Text = dr.IsDBNull(tableCol["Shortcut"]) ? "" : dr.GetString("Shortcut");
                    tempEn = Globals.RmSpace(NameEnTB.Text);
                    tempAr = Globals.RmSpace(NameArTB.Text);
                    tempShortcut = Globals.RmSpace(ShortcutTB.Text);
                }
            }
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            string SQL;
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            if (NameEnTB.Text == "" || NameArTB.Text == "" || ShortcutTB.Text == "")
            {
                MessageBox.Show("Please fill all the Feilds");
                return;
            }
            if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text)) || Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text)) || Globals.ifExist(SQLtable, "Shortcut", Globals.RmSpace(ShortcutTB.Text)))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (NameEn, NameAr, Shortcut) VALUES(@NameEn, @NameAr, @Shortcut);";

            }
            else
            {
                if ((!Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text)) && tempEn == NameEnTB.Text) || (!Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text)) && tempAr == NameArTB.Text) || (!Globals.ifExist(SQLtable, "Shortcut", Globals.RmSpace(ShortcutTB.Text)) && tempShortcut == ShortcutTB.Text))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"UPDATE {SQLtable} SET NameEn=@NameEn, NameAr=@NameAr, Shortcut=@Shortcut WHERE ID=@ID;";
                myPara.Add("@ID", ID);

            }

            myPara.Add("@NameEn", Globals.RmSpace(NameEnTB.Text));
            myPara.Add("@NameAr", Globals.RmSpace(NameArTB.Text));
            myPara.Add("@Shortcut", Globals.RmSpace(ShortcutTB.Text));
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();
        }
    }
}
