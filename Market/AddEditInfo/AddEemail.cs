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
    public partial class AddEemail : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable;
        public int selectedID;
        public string command;
        public string Email;
        public AddEemail()
        {
            InitializeComponent();
        }

        public AddEemail(string cmd, string table, int id, string e = "")
        {
            InitializeComponent();
            SQLtable = table;
            selectedID = id;
            command = cmd;
            applyB.Text = cmd.ToUpper();
            EmailTB.Text = Email=e;

        }

        private void applyB_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL = "";
            Globals.CleanTB(this.Controls);
            if (EmailTB.Text == "")
            {
                MessageBox.Show("Please use valid email");
                return;
            }

            if (command == "edit")
            {
                if (Globals.ifExist(SQLtable, "EmailAddress", EmailTB.Text, selectedID))
                {
                    MessageBox.Show("this email is alredy used");
                    return;
                }
                SQL = $"UPDATE {SQLtable} SET EmailAddress= @EmailAddressNew WHERE EmailAddress=@EmailAddress";
                myPara.Add("@EmailAddress", Email);
            }
            else if (command == "add")
            {
                if (Globals.ifExist(SQLtable, "EmailAddress", EmailTB.Text))
                {
                    MessageBox.Show("this email is alredy used");
                    return;
                }

                SQL = $@"INSERT INTO {SQLtable} (UserID, EmailAddress) VALUES(@UserID, @EmailAddressNew);";
            }


            myPara.Add("@UserID", selectedID);
            myPara.Add("@EmailAddressNew", EmailTB.Text);
            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            MessageBox.Show("Done!!");
            this.Close();


        }

    }
}
