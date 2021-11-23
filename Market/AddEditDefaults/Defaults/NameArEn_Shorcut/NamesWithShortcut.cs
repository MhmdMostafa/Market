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
                if (Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text.ToUpper())) || Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text)) || Globals.ifExist(SQLtable, "Shortcut", Globals.RmSpace(ShortcutTB.Text.ToUpper())))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (NameEn, NameAr, Shortcut) VALUES(@NameEn, @NameAr, @Shortcut);";

            }
            else
            {
                if (Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text.ToUpper()), ID) || Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text), ID) || Globals.ifExist(SQLtable, "Shortcut", Globals.RmSpace(ShortcutTB.Text.ToUpper()), ID))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"UPDATE {SQLtable} SET NameEn=@NameEn, NameAr=@NameAr, Shortcut=@Shortcut WHERE ID=@ID;";
                myPara.Add("@ID", ID);

            }

            myPara.Add("@NameEn", Globals.RmSpace(NameEnTB.Text.ToUpper()));
            myPara.Add("@NameAr", Globals.RmSpace(NameArTB.Text));
            myPara.Add("@Shortcut", Globals.RmSpace(ShortcutTB.Text.ToUpper()));
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();
        }
    }
}
