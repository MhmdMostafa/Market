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
namespace Market
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            string username="", pass="";
            if (File.Exists(@"setup.cfg"))
            using (StreamReader sr = new StreamReader(@"setup.cfg"))
            {
                string _line;
                    int count = 1;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split(':');
                    if (keyvalue.Length == 2)
                    {
                            if (count == 1)
                                username = keyvalue[1];
                            else
                                pass = keyvalue[1];
                    }
                }
            }
            
            this.Hide();
            MainForm MainWindow = new MainForm();
            MainWindow.Closed += (s, args) => this.Close();
            MainWindow.Show();
        }
    }
}
