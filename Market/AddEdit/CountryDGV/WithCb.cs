﻿using System;
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
    public partial class WithCb : MaterialSkin.Controls.MaterialForm
    {
        public static int ID;
        public static string SQLtable;
        public static string command;
        public static string tempEn;
        public static string tempAr;
        public static string tempContinentID;
        public static string tempCallingCode;
        public static string tempShortcut;
        Dictionary<string, int> tableCol = new Dictionary<string, int>();
        Dictionary<string, int> ContinentCol = new Dictionary<string, int>();
        public WithCb()
        {
            InitializeComponent();
        }

        public WithCb(string conf, string table, int SelectedId = 0)
        {
            InitializeComponent();
            ID = SelectedId;
            SQLtable = table;
            command = conf;
            string SQL;
            ContinentCol = Globals.GetColumnsIndex("continents");
            tableCol = Globals.GetColumnsIndex(table);

            Text = $"{command.ToUpper()} Wizerd";
            AddEditBT.Text = command.ToUpper();

            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM continents;"))
                while (dr.Read())
                {
                    ContinentCB.Items.Add(dr.IsDBNull(ContinentCol["NameEn"]) ? "" : dr.GetString("NameEn"));
                }
            if (command == "edit")
            {
                SQL = $@"SELECT * FROM {SQLtable} WHERE ID={ID}";
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                {
                    dr.Read();
                    NameEnTB.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                    NameArTB.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                    ContinentCB.SelectedIndex = dr.IsDBNull(tableCol["ContinentID"]) ? 0 : int.Parse(dr.GetString("ContinentID")) - 1;
                    CallingCodeTB.Text = dr.IsDBNull(tableCol["CallingCode"]) ? "" : dr.GetString("CallingCode");
                    ShortcutTB.Text = dr.IsDBNull(tableCol["Shortcut"]) ? "" : dr.GetString("Shortcut");

                    tempContinentID = Globals.RmSpace(ContinentCB.Text);
                    tempEn = Globals.RmSpace(NameEnTB.Text);
                    tempAr = Globals.RmSpace(NameArTB.Text);
                    tempShortcut = Globals.RmSpace(ShortcutTB.Text);
                    tempCallingCode = Globals.RmSpace(CallingCodeTB.Text);
                }
            }
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            string SQL;
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            if (NameEnTB.Text == "" || NameArTB.Text == "" || ShortcutTB.Text == "" || CallingCodeTB.Text == "")
            {
                MessageBox.Show("Please fill all the Feilds");
                return;
            }
            if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text)) || Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text)) || Globals.ifExist(SQLtable, "Shortcut", Globals.RmSpace(ShortcutTB.Text)) || Globals.ifExist(SQLtable, "CallingCode", Globals.RmSpace(CallingCodeTB.Text)))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (NameEn, NameAr, ContinentID, CallingCode, Shortcut) VALUES(@NameEn, @NameAr, @ContinentID, @CallingCode, @Shortcut);";

            }
            else
            {
                if ((!Globals.ifExist(SQLtable, "NameEn", Globals.RmSpace(NameEnTB.Text)) && tempEn == NameEnTB.Text) || (!Globals.ifExist(SQLtable, "NameAr", Globals.RmSpace(NameArTB.Text)) && tempAr == NameArTB.Text) || (!Globals.ifExist(SQLtable, "CallingCode", Globals.RmSpace(CallingCodeTB.Text)) && tempCallingCode == CallingCodeTB.Text) || (!Globals.ifExist(SQLtable, "Shortcut", Globals.RmSpace(ShortcutTB.Text)) && tempShortcut == ShortcutTB.Text))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"UPDATE {SQLtable} SET NameEn=@NameEn, NameAr=@NameAr, ContinentID=@ContinentID, CallingCode=@CallingCode, Shortcut=@Shortcut WHERE ID=@ID;";
                myPara.Add("@ID", ID);

            }

            myPara.Add("@NameEn", Globals.RmSpace(NameEnTB.Text));
            myPara.Add("@NameAr", Globals.RmSpace(NameArTB.Text));
            myPara.Add("@ContinentID", Globals.GetID("ID", "continents", "NameEn", ContinentCB.Text));
            myPara.Add("@CallingCode", Globals.RmSpace(CallingCodeTB.Text));
            myPara.Add("@Shortcut", Globals.RmSpace(ShortcutTB.Text));
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();
        }
    }
}
