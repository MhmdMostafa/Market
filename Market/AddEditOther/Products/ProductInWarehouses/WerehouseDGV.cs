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
            Text = "Werehouse Products";
            refresh();
        }

        public void refresh()
        {
            string SQL = $"SELECT products_stock.ID, products.NameEn AS Product, suppliers.NameEn AS Supplier, warehouses.NameEn AS Warehouse, CostPrice, currencies.Shortcut, products_stock.Description, Quantity, Available, DateOfProduction, ExpiryDate, products_stock.Barcode, nav_sections.NameEn AS Section, nav_rows.NameEn AS nav_row, nav_columns.NameEn AS nav_column FROM products_stock INNER JOIN products ON products_stock.ProductID=products.ID INNER JOIN suppliers ON products_stock.SupplierID=suppliers.ID INNER JOIN warehouses ON products_stock.WerehouseID=warehouses.ID INNER JOIN currencies ON products_stock.CurrencyID=currencies.ID INNER JOIN nav_sections ON products_stock.SectionID=nav_sections.ID INNER JOIN nav_rows ON products_stock.RowID=nav_rows.ID INNER JOIN nav_columns ON products_stock.ColumnID=nav_columns.ID;";
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

            AddEditWerehouse window = new AddEditWerehouse("edit", selectedValues[0]);
            window.ShowDialog();
            refresh();
        }
    }
}
