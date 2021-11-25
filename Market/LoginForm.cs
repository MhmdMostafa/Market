using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
namespace Market
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            bool flag = false;
            MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT * FROM emp_employees");

            string pass=Globals.encrypt(UserPasswordTB.Text);
            
            while (dr.Read())
            {
                if (dr.GetString("UserName") == UserNameTB.Text)
                    if (dr.GetString("Pass_word") == pass)
                    {
                        flag = true;
                        break;
                    }

            }
            if (flag)
            {
                this.Hide();
                MainForm MainWindow = new MainForm();
                MainWindow.Closed += (s, args) => this.Close();
                MainWindow.Show();
            }
            else
                MessageBox.Show("User name or password is incorrect!!");
        }

    }
}
