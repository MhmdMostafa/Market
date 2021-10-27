using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class MainForm : Form
    {
        MySQL_CRUD CRUD = new MySQL_CRUD("MySQL.cfg");
        public MainForm()
        {
            InitializeComponent();
        }
         
        public void OptionsMenuB_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionsForm MainWindow = new OptionsForm();
            MainWindow.Closed += (s, args) => this.Show();
            MainWindow.Show();
        }

        private void NewInvoiceB_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewInvoiceForm MainWindow = new NewInvoiceForm();
            MainWindow.Closed += (s, args) => this.Show();
            MainWindow.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewProduct MainWindow = new NewProduct();
            MainWindow.Closed += (s, args) => this.Show();
            MainWindow.Show();
        }
    }
}
