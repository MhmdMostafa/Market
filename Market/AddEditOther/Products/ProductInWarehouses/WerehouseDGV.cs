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
    public partial class WerehouseDGV : MaterialSkin.Controls.MaterialForm
    {
        public WerehouseDGV()
        {
            InitializeComponent();
            Text = "Products";
            refresh();
        }

        public void refresh()
        {
            string SQL = $"SELECT products.ID, products.NameEn, products.NameAr, Size, Price, Barcode, UPC, SKU, ISBN, products_groub.NameEn as ProductGroubID, products_type.NameEn as ProductTypeID, units_value.Shortcut as UnitValueID, currencies.Shortcut as CurrencyID FROM products INNER JOIN products_groub ON products.ProductGroubID=products_groub.ID INNER JOIN products_type ON products.ProductTypeID=products_type.ID INNER JOIN units_value ON products.UnitValueID=units_value.ID INNER JOIN currencies ON products.CurrencyID=currencies.ID;";
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
            AddEditProducts window = new AddEditProducts("add");
            window.ShowDialog();
            refresh();
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            List<int> selectedValues = Globals.GetSelectedValues(ProductsDGV);
            if (selectedValues.Count > 1)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }
            else if (selectedValues.Count == 0)
            {
                MessageBox.Show("Please Select one value to edit");
                return;
            }

            AddEditProducts window = new AddEditProducts("edit", selectedValues[0]);
            window.ShowDialog();
            refresh();
        }
    }
}
