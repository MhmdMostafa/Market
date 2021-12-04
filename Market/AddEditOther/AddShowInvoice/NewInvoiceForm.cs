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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;
namespace Market
{
    public partial class NewInvoiceForm : MaterialSkin.Controls.MaterialForm
    {
        public ComboBox selectedProductCb;
        public float Total = 0;
        public float TotalAfterDiscont, VAT, TotalVat, FinalTotal, crediet, Remain;
        public Bitmap qr;
        public int maxID;
        DateTime date;
        public NewInvoiceForm(string conf, int id = 0)
        {
            InitializeComponent();
            Globals.refreshCb(CustomerCb, "customers", "NameEn");
            Globals.refreshCb(InvoiceTypeCb, "invoice_type", "NameEn");
            Globals.refreshCb(PaymentMethodCb, "payment_methods", "NameEn");
            Globals.refreshCb(currencyCb, "currencies", "Shortcut");
            refresh();
            refreshDGV();
            if (conf == "Show")
            {
                dataGridView.Enabled = false;
                groupBox2.Enabled = false;
                SubmitB.Enabled = false;
            }

        }



        public void refresh()
        {

            string QRstr = "";
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("select * from main_info;"))
            {
                dr.Read();
                VAT = dr.GetFloat("VatValue");
                VATL.Text = $"{VAT}";
                QRstr = $"TaxNo.{dr.GetString("TaxNumber")},{dr.GetString("NameEn")},";
            }
            toolStripStatusLabel1.Text = $"User: {Globals.UserNameLogedin}|";
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("select max(ID) from invoices;"))
            {
                dr.Read();
                maxID = dr.IsDBNull(0) ? 0 : dr.GetInt32("max(ID)");
                toolStripStatusLabel2.Text = $"Invoice No: {maxID + 1}|";
            }
            date = DateTime.Now;
            toolStripStatusLabel3.Text = $"Date: {date.ToString("dd/MM/yyyy")}|";
            toolStripStatusLabel4.Text = $"Time: {date.ToString("hh:mm:ss tt")}";

            TotalL.Text = $"{Total}";
            TotalAfterDiscont = Total - (float)DiscountValueTb.Value;
            TotalAfterDiscountL.Text = $"{TotalAfterDiscont}";


            TotalVat = TotalAfterDiscont * VAT;
            TotalVATL.Text = $"{TotalVat}";

            FinalTotal = TotalAfterDiscont + TotalVat;
            FinalTotalL.Text = $"{FinalTotal}";
            QRstr += $"Total Vat:{TotalVat},Final Total:{FinalTotal}";
            PaidL.Text = $"{PaidAmountTb.Value}";
            Remain = ((float)PaidAmountTb.Value - FinalTotal) > 0 ? ((float)PaidAmountTb.Value - FinalTotal) : 0;
            RemainL.Text = $"{Remain}";

            crediet = ((float)PaidAmountTb.Value - FinalTotal) < 0 ? ((float)PaidAmountTb.Value - FinalTotal) * -1 : 0;

            CreditValueL.Text = $"{crediet}";
            qr = Globals.GenerateQR(QRstr);
            qr.Save($"ID_{maxID + 1}.png", ImageFormat.Png);
            this.pictureBox1.Image = qr;
        }

        public void refreshDGV()
        {
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql("SELECT products_stock.ID, products.NameEn FROM products_stock INNER JOIN products ON  products_stock.ProductID=products.ID"))
            {
                while (dr.Read())
                {
                    ProductNameEnCol.Items.Add($"{dr.GetString("ID")}-{dr.GetString("NameEn")}");
                }
            }
        }

        private void PaidAmountTb_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }
        private void DiscountValueTb_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void SelectAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCB.Checked)
                Globals.Clean_SelectCbList(dataGridView, true);
            else
                Globals.Clean_SelectCbList(dataGridView, false);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WerehouseDGV window = new WerehouseDGV();
            window.ShowDialog();
            refreshDGV();
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            refresh();
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            List<Dictionary<string, object>> products = new List<Dictionary<string, object>>();
            string execPath = Assembly.GetEntryAssembly().Location;
            Excel.Application XlApp = new Excel.Application { Visible = true, EnableAnimations = true, ScreenUpdating = true };
            Excel.Workbook XlWorkBook = XlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet XlWorkSheet = (Excel.Worksheet)XlWorkBook.Worksheets.get_Item(1);
            XlWorkSheet.Name = "Invoice";
            XlWorkSheet.Cells.NumberFormat = "@";

            XlWorkSheet.Cells[3, 1].RowHeight = 45;
            XlWorkSheet.Cells[4, 1].RowHeight = 45;
            XlWorkSheet.Columns[1].ColumnWidth = 25;
            XlWorkSheet.Columns[2].ColumnWidth = 5;
            XlWorkSheet.Columns[3].ColumnWidth = 10;
            XlWorkSheet.Columns[4].ColumnWidth = 15;

            XlWorkSheet.Range[XlWorkSheet.Cells[3, 2], XlWorkSheet.Cells[3, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[4, 2], XlWorkSheet.Cells[4, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[3, 2], XlWorkSheet.Cells[4, 2]].Merge();

            XlWorkSheet.Range[XlWorkSheet.Cells[1, 1], XlWorkSheet.Cells[1, 4]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[2, 1], XlWorkSheet.Cells[2, 4]].Merge();

            XlWorkSheet.Cells[1, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            XlWorkSheet.Cells[2, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            XlWorkSheet.Cells[3, 1].RowHeight = 40;

            XlWorkSheet.Range[XlWorkSheet.Cells[20, 1], XlWorkSheet.Cells[20, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[21, 1], XlWorkSheet.Cells[21, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[22, 1], XlWorkSheet.Cells[22, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[23, 1], XlWorkSheet.Cells[23, 3]].Merge();
            XlWorkSheet.Cells[20, 1].HorizontalAlignment = XlHAlign.xlHAlignRight;
            XlWorkSheet.Cells[21, 1].HorizontalAlignment = XlHAlign.xlHAlignRight;
            XlWorkSheet.Cells[22, 1].HorizontalAlignment = XlHAlign.xlHAlignRight;
            XlWorkSheet.Cells[23, 1].HorizontalAlignment = XlHAlign.xlHAlignRight;

            XlWorkSheet.Cells[1, 1] = "صيدلية يوسف عبدالله الفويز البيطرية";

            XlWorkSheet.Cells[2, 1] = "Youssef Abdullah Al-Fawaz Veterinary Pharmacy";


            XlWorkSheet.Cells[3, 1] = "Tax No:\n300576277800003";
            XlWorkSheet.Cells[3, 4] = "الرقم الضريبي:\n300576277800003";

            XlWorkSheet.Cells[4, 1] = "Commercial Register:\n1131293352";
            XlWorkSheet.Cells[4, 4] = "السجل التجاري:\n1131293352";


            XlWorkSheet.Cells[5, 1] = "Product";
            XlWorkSheet.Cells[5, 2] = "Qu";
            XlWorkSheet.Cells[5, 3] = "Price";
            XlWorkSheet.Cells[5, 4] = "Total";

            XlWorkSheet.Cells[20, 1] = "Total";
            XlWorkSheet.Cells[21, 1] = "Discount";
            XlWorkSheet.Cells[22, 1] = "Vat";
            XlWorkSheet.Cells[23, 1] = "Final Totlal";

            XlWorkSheet.Shapes.AddPicture($"{execPath.Replace("Market.exe", "")}ID_{maxID + 1}.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 140, 35, 80, 80);
            XlWorkSheet.Cells.WrapText = true;
            int xlrow = 6;
            string[] spliter;
            string s1, s2;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {

                if (row.Cells[2].Value == null)
                    break;
                Dictionary<string, object> t = new Dictionary<string, object>();
                spliter = row.Cells[1].Value.ToString().Split('-');
                s1 = row.Cells[2].Value.ToString();
                s2 = row.Cells[3].Value.ToString();
                XlWorkSheet.Cells[xlrow, 1] = spliter[1];
                XlWorkSheet.Cells[xlrow, 2] = row.Cells[2].Value.ToString();
                XlWorkSheet.Cells[xlrow, 3] = row.Cells[3].Value.ToString();
                XlWorkSheet.Cells[xlrow, 4] = float.Parse(s1) * float.Parse(s2);



                t.Add("@InvoiceID", maxID + 1);
                t.Add("@ProductID", int.Parse(spliter[0]));
                t.Add("@Price", float.Parse(row.Cells[3].Value.ToString()));
                t.Add("@Size", int.Parse(row.Cells[4].Value.ToString()));
                t.Add("@UnitValueID", Globals.GetIdByString("units_value", "Shortcut", row.Cells[5].Value.ToString()));
                t.Add("@Quantity", int.Parse(row.Cells[2].Value.ToString()));

                products.Add(t);
                xlrow++;
            }

            XlWorkSheet.Cells[20, 4] = Total.ToString();
            XlWorkSheet.Cells[21, 4] = DiscountValueTb.Value.ToString();
            XlWorkSheet.Cells[22, 4] = TotalVat.ToString();
            XlWorkSheet.Cells[23, 4] = FinalTotal.ToString();


            string SQL = $"INSERT INTO market.invoices (InvoiceTypeID, PaymentMethodID, PaymentMechanismeID, EmpID, CustomerID, InvoiceDate, InvoiceTime, Discount, TotalDiscount, TotalVAT, Total, FinalTotal, Paid, Credit, Remain, CurrencyID, Barcode, QRcode, Description) VALUES(@InvoiceTypeID, @PaymentMethodID, @PaymentMechanismeID, @EmpID, @CustomerID, @InvoiceDate, @InvoiceTime, @Discount, @TotalDiscount, @TotalVAT, @Total, @FinalTotal, @Paid, @Credit, @Remain, @CurrencyID, @Barcode, @QRcode, @Description);";

            myPara.Clear();
            myPara.Add("@InvoiceTypeID", Globals.GetIdByString("invoice_type", "NameEn", InvoiceTypeCb.Text));
            myPara.Add("@PaymentMethodID", Globals.GetIdByString("payment_methods", "NameEn", PaymentMethodCb.SelectedItem.ToString()));
            myPara.Add("@PaymentMechanismeID", 1);
            myPara.Add("@EmpID", Globals.GetIdByString("employees", "UserName", Globals.UserNameLogedin));
            myPara.Add("@CustomerID", Globals.GetIdByString("customers", "NameEn", CustomerCb.SelectedItem.ToString()));
            myPara.Add("@InvoiceDate", date.ToString("dd/MM/yy"));
            myPara.Add("@InvoiceTime", date.ToString("hh:mm:ss"));
            myPara.Add("@Discount", (float)DiscountValueTb.Value);
            myPara.Add("@TotalDiscount", Total - (float)DiscountValueTb.Value);
            myPara.Add("@TotalVAT", TotalVat);
            myPara.Add("@Total", Total);
            myPara.Add("@FinalTotal", FinalTotal);
            myPara.Add("@Paid", (float)PaidAmountTb.Value);
            myPara.Add("@Credit", crediet);
            myPara.Add("@Remain", Remain);
            myPara.Add("@CurrencyID", Globals.GetIdByString("currencies", "Shortcut", currencyCb.SelectedItem.ToString()));
            myPara.Add("@Barcode", $"{maxID + 1} barcode, {date.ToString("dd/MM/yy  hh:mm:ss tt")}");
            myPara.Add("@QRcode", qr);
            myPara.Add("@Description", $"new Invoice {date.ToString("dd/MM/yy  hh:mm:ss tt")}");

            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);

            SQL = "INSERT INTO sales (InvoiceID, ProductID, Quantity, Price, Size, UnitValueID) VALUES(@InvoiceID, @ProductID, @Quantity, @Price, @Size, @UnitValueID);";
            foreach (Dictionary<string, object> a in products)
            {
                Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, a);
            }
        }





        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var currentcell = dataGridView.CurrentCellAddress;
            if (currentcell.X == 2)
            {
                string s1, s2;
                Total = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[2].Value == null)
                        break;
                    s1 = row.Cells[2].Value.ToString();
                    s2 = row.Cells[3].Value.ToString();
                    Total += float.Parse(s1) * float.Parse(s2);
                    refresh();

                }
            }
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dataGridView.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                selectedProductCb = comboBox;
                comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }


        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView.CurrentCellAddress;
            string[] spliter = selectedProductCb.Text.Split('-');

            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql($"SELECT products.Price, products.Size, units_value.Shortcut AS UnitValue, products_stock.ExpiryDate, products_stock.Barcode, products_stock.Quantity FROM products_stock inner join products on products_stock.ID = products.ID INNER JOIN units_value ON products.UnitValueID = units_value.ID WHERE products_stock.ID = {int.Parse(spliter[0])}"))
            {
                dr.Read();
                dataGridView.Rows[currentcell.Y].Cells[3].Value = dr.GetString("Price");
                dataGridView.Rows[currentcell.Y].Cells[4].Value = dr.GetString("Size");
                dataGridView.Rows[currentcell.Y].Cells[5].Value = dr.GetString("UnitValue");
                dataGridView.Rows[currentcell.Y].Cells[6].Value = dr.GetString("ExpiryDate");
                dataGridView.Rows[currentcell.Y].Cells[7].Value = dr.GetString("Barcode");

            }



        }

        private void AddCustomerB_Click(object sender, EventArgs e)
        {
            CustomersDGV window = new CustomersDGV();
            window.ShowDialog();
            Globals.refreshCb(InvoiceTypeCb, "invoice_type", "NameEn");
        }
    }
}
