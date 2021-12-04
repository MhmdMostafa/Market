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
    public partial class ShowInv : MaterialSkin.Controls.MaterialForm
    {
        public ComboBox selectedProductCb;
        public float Total = 0;
        public float TotalAfterDiscont, VAT, TotalVat, FinalTotal, crediet, Remain;
        public Bitmap qr;
        public int maxID;
        DateTime date;
        public ShowInv(int id)
        {
            InitializeComponent();
            string SQL = $"SELECT products.NameEn, sales.Price, sales.Size, units_value.Shortcut, Quantity FROM sales INNER JOIN products ON sales.ProductID=products.ID INNER JOIN units_value ON sales.UnitValueID=units_value.ID WHERE InvoiceID=7";
            dataGridView.DataSource = Globals.myCrud.getDtPassSql(SQL);



        }

    }
}
