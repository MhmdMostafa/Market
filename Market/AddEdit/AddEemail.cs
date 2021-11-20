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
    public partial class AddEemail : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable;
        public string oldEmail;
        public int selectedID;
        public string command;
        public AddEemail()
        {
            InitializeComponent();
        }

        public AddEemail(string cmd, string table, int id, string e = "")
        {
            InitializeComponent();
            SQLtable = table;
            oldEmail = e;
            selectedID = id;
            command = cmd;
            EmailTB.Text = e;
            applyB.Text = cmd.ToUpper();
            if (command == "edit")
            {
                EmailTB.Text = e;
            }


        }

        private void applyB_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = "";

            if (EmailTB.Text == "")
            {
                MessageBox.Show("Please use valid email");
                return;
            }

            if (command == "edit")
            {
                SQL = $"UPDATE {SQLtable} SET EmailAddress= @EmailAddressNew WHERE UserID = @UserID AND EmailAddress = @EmailAddressOld";
                myPara.Add("@EmailAddressOld", Globals.RmSpace(oldEmail));
            }
            else if (command == "add")
            {
                SQL = $@"INSERT INTO {SQLtable} (UserID, EmailAddress) VALUES(@UserID, @EmailAddressNew);";
            }
            if (Globals.ifExist(SQLtable, "EmailAddress", Globals.RmSpace(oldEmail)) || Globals.RmSpace(EmailTB.Text) == oldEmail)
            {
                MessageBox.Show("this email is alredy used");
            }
            else
            {
                myPara.Add("@UserID", selectedID);
                myPara.Add("@EmailAddressNew", Globals.RmSpace(EmailTB.Text));
                Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

                this.Close();
            }

        }

    }
}