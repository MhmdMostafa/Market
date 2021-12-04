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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm window = new OptionsForm();
            window.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainCustomer window = new MainCustomer("add");
            window.ShowDialog();
        }

        private void custmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersDGV window = new CustomersDGV();
            window.ShowDialog();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductsInfoDGV window = new ProductsInfoDGV();
            window.ShowDialog();
        }

        private void productsInWerehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WerehouseDGV window = new WerehouseDGV();
            window.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditProducts window = new AddEditProducts("add");
            window.ShowDialog();
        }

        private void addToWerehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditWerehouse window = new AddEditWerehouse("add");
            window.ShowDialog();
        }

        private void invoiceiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInvoiceForm window = new NewInvoiceForm("add");
            window.ShowDialog();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceDGV window = new InvoiceDGV();
            window.ShowDialog();
        }
    }
}
