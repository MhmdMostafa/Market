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
    public partial class SalesDGV : MaterialSkin.Controls.MaterialForm
    {
        public SalesDGV()
        {
            InitializeComponent();
            Text = "Werehouse Products";
            refresh();
        }

        public void refresh()
        {
            string SQL = $"SELECT * From sales;";
            ProductsDGV.DataSource = Globals.myCrud.getDtPassSql(SQL);
        }




    }
}
