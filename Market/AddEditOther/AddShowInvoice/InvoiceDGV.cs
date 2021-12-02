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
    public partial class InvoiceDGV : MaterialSkin.Controls.MaterialForm
    {
        public InvoiceDGV()
        {
            InitializeComponent();
            Text = "Werehouse Products";
            refresh();
        }

        public void refresh()
        {
            string SQL = $"SELECT invoices.ID, invoice_type.NameEn AS InvoiceType, payment_methods.NameEn AS PaymentMethod, payment_mechanisms.NameEn AS PaymentMechanisme, employees.NameEn AS Emp, customers.NameEn Customer, InvoiceDate, Discount,TotalDiscount,TotalVAT, Total, FinalTotal, Paid, Credit, Remain, currencies.Shortcut AS Currency, Barcode, QRcode, Description, main_info.CommercialRegister, main_info.TaxNumber, main_info.ContactNumber, main_info.NameEn,main_info.NameAr, , main_info.VatValue FROM invoices INNER JOIN invoice_type ON invoices.InvoiceTypeID = invoice_type.ID INNER JOIN payment_methods ON invoices.PaymentMethodID = payment_methods.ID INNER JOIN payment_mechanisms ON invoices.PaymentMechanismeID = payment_mechanisms.ID INNER JOIN employees ON invoices.EmpID = employees.ID INNER JOIN customers ON invoices.CustomerID = customers.ID INNER JOIN currencies ON invoices.CurrencyID = currencies.ID LEFT OUTER JOIN main_info ON invoices.InfoID = main_info.ID;";
            ProductsDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
        }

        private void SelectAllCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCb.Checked)
                Globals.Clean_SelectCbList(ProductsDGV, true);
            else
                Globals.Clean_SelectCbList(ProductsDGV, false);
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            AddEditWerehouse window = new AddEditWerehouse("add");
            window.ShowDialog();
            refresh();
        }


        private void ShowInv_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(ProductsDGV);
            if (selectedValues.Count > 1)
            {
                MessageBox.Show("Please Select one value to Show");
                return;
            }
            else if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to Show");
                return;
            }

            AddEditWerehouse window = new AddEditWerehouse("Show", selectedValues[0]);
            window.ShowDialog();
            refresh();
        }
    }
}
