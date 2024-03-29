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

            Globals.refreshCb(ContinentCB, "continents", "NameEn");
            if (command == "edit")
            {
                SQL = $@"SELECT * FROM {SQLtable} WHERE ID={ID}";
                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                {
                    dr.Read();
                    NameEnTB.Text = dr.IsDBNull(tableCol["NameEn"]) ? "" : dr.GetString("NameEn");
                    NameArTB.Text = dr.IsDBNull(tableCol["NameAr"]) ? "" : dr.GetString("NameAr");
                    ContinentCB.SelectedItem = dr.IsDBNull(tableCol["ContinentID"]) ? "" : Globals.GetStringById("NameEn", "continents", dr.GetInt32("ContinentID"));
                    CallingCodeTB.Text = dr.IsDBNull(tableCol["CallingCode"]) ? "" : dr.GetString("CallingCode");
                    ShortcutTB.Text = dr.IsDBNull(tableCol["Shortcut"]) ? "" : dr.GetString("Shortcut");

                }
            }
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            string SQL;
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            Globals.CleanTB(this.Controls);

            if (NameEnTB.Text == "" || NameArTB.Text == "" || ShortcutTB.Text == "" || CallingCodeTB.Text == "")
            {
                MessageBox.Show("Please fill all the Feilds");
                return;
            }
            if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "NameEn", NameEnTB.Text) || Globals.ifExist(SQLtable, "NameAr", NameArTB.Text) || Globals.ifExist(SQLtable, "Shortcut", ShortcutTB.Text) || Globals.ifExist(SQLtable, "CallingCode", CallingCodeTB.Text))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"INSERT INTO {SQLtable} (NameEn, NameAr, ContinentID, CallingCode, Shortcut) VALUES(@NameEn, @NameAr, @ContinentID, @CallingCode, @Shortcut);";

            }
            else
            {
                if (Globals.ifExist(SQLtable, "NameEn", NameEnTB.Text, ID) || Globals.ifExist(SQLtable, "NameAr", NameArTB.Text, ID) || Globals.ifExist(SQLtable, "CallingCode", CallingCodeTB.Text, ID) || Globals.ifExist(SQLtable, "Shortcut", ShortcutTB.Text, ID))
                {
                    MessageBox.Show("Entry is alredy exist");
                    return;
                }
                SQL = $@"UPDATE {SQLtable} SET NameEn=@NameEn, NameAr=@NameAr, ContinentID=@ContinentID, CallingCode=@CallingCode, Shortcut=@Shortcut WHERE ID=@ID;";
                myPara.Add("@ID", ID);

            }

            myPara.Add("@NameEn", NameEnTB.Text);
            myPara.Add("@NameAr", NameArTB.Text);
            myPara.Add("@ContinentID", Globals.GetIdByString("continents", "NameEn", ContinentCB.Text));
            myPara.Add("@CallingCode", CallingCodeTB.Text);
            myPara.Add("@Shortcut", ShortcutTB.Text);
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();
        }

        private void CallingCodeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;

            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (CallingCodeTB.Text.Length == 2)
            {
                CallingCodeTB.Text += "/";
                CallingCodeTB.SelectionStart = CallingCodeTB.Text.Length;
            }
        }
    }
}
