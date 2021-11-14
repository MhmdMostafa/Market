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
            
            
            this.Hide();
            MainForm MainWindow = new MainForm();
            MainWindow.Closed += (s, args) => this.Close();
            MainWindow.Show();
        }
    }
}
