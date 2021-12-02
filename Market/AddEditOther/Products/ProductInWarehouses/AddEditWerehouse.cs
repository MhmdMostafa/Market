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
namespace Market
{
    public partial class AddEditWerehouse : MaterialSkin.Controls.MaterialForm
    {
        public int SelectedID;
        public string command;
        public Dictionary<string, int> ProductsCol = new Dictionary<string, int>();
        public AddEditWerehouse()
        {
            InitializeComponent();
        }


        public AddEditWerehouse(string conf, int id = 0)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;

            ProductsCol = Globals.GetColumnsIndex("products_stock");

            Globals.refreshCb(productCb, "products", "NameEn");
            Globals.refreshCb(supplaierCb, "suppliers", "NameEn");
            Globals.refreshCb(currencyCb, "currencies", "Shortcut");

            Globals.refreshCb(WerehouseCb, "warehouses", "NameEn");
            Globals.refreshCb(SectionCb, "nav_sections", "NameEn");
            Globals.refreshCb(RowCb, "nav_rows", "NameEn");
            Globals.refreshCb(ColumnCb, "nav_columns", "NameEn");

            AvailableCb.SelectedIndex = 0;

            if (command == "edit")
            {
                Text = "Edit Product Wizerd";
                AddEditBT.Text = "Edit";
                string SQL = $@"SELECT products_stock.ID, products.NameEn AS Product, suppliers.NameEn AS Supplier, warehouses.NameEn AS Warehouse, CostPrice, currencies.Shortcut, products_stock.Description, Quantity, Available, DateOfProduction, ExpiryDate, products_stock.Barcode, nav_sections.NameEn AS Section, nav_rows.NameEn AS nav_row, nav_columns.NameEn AS nav_column FROM products_stock INNER JOIN products ON products_stock.ProductID=products.ID INNER JOIN suppliers ON products_stock.SupplierID=suppliers.ID INNER JOIN warehouses ON products_stock.WerehouseID=warehouses.ID INNER JOIN currencies ON products_stock.CurrencyID=currencies.ID INNER JOIN nav_sections ON products_stock.SectionID=nav_sections.ID INNER JOIN nav_rows ON products_stock.RowID=nav_rows.ID INNER JOIN nav_columns ON products_stock.ColumnID=nav_columns.ID;";

                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                {
                    dr.Read();
                    productCb.SelectedItem = dr.IsDBNull(ProductsCol["ProductID"]) ? "" : dr.GetString("Product");
                    supplaierCb.SelectedItem = dr.IsDBNull(ProductsCol["SupplierID"]) ? "" : dr.GetString("Supplier");
                    WerehouseCb.SelectedItem = dr.IsDBNull(ProductsCol["WerehouseID"]) ? "" : dr.GetString("Warehouse");
                    AvailableCb.SelectedItem = dr.IsDBNull(ProductsCol["Available"]) ? "" : dr.GetString("Available");
                    costPriceTb.Value = dr.IsDBNull(ProductsCol["CostPrice"]) ? 0 : (decimal)dr.GetFloat("CostPrice");
                    currencyCb.SelectedItem = dr.IsDBNull(ProductsCol["CurrencyID"]) ? "" : dr.GetString("Shortcut");
                    barcodeTb.Text = dr.IsDBNull(ProductsCol["Barcode"]) ? "" : dr.GetString("Barcode");
                    quantTb.Text = dr.IsDBNull(ProductsCol["Quantity"]) ? "" : dr.GetString("Quantity");
                    ProductionDate.Text = dr.IsDBNull(ProductsCol["DateOfProduction"]) ? "" : dr.GetString("DateOfProduction");
                    ExpiryDate.Text = dr.IsDBNull(ProductsCol["ExpiryDate"]) ? "" : dr.GetString("ExpiryDate");
                    SectionCb.Text = dr.IsDBNull(ProductsCol["SectionID"]) ? "" : dr.GetString("Section");
                    RowCb.Text = dr.IsDBNull(ProductsCol["RowID"]) ? "" : dr.GetString("nav_row");
                    ColumnCb.Text = dr.IsDBNull(ProductsCol["ColumnID"]) ? "" : dr.GetString("nav_column");
                }
            }
            else
            {
                Text = "Add Product to Werehouse Wizerd";
                AddEditBT.Text = "Add";
            }
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL;
            Globals.CleanTB(Controls);



            if (costPriceTb.Value == 0 || quantTb.Value == 0 || barcodeTb.Text == "" || productCb.Text == "" || supplaierCb.Text == "")
            {
                MessageBox.Show("Please Fill all needed inf");
                return;
            }
            if (command == "edit")
            {
                if (Globals.ifExist("products", "barcode", barcodeTb.Text, SelectedID) && barcodeTb.Text != "")
                {
                    MessageBox.Show("This Vat Number is alredy Exist");
                    return;
                }
                SQL = $"UPDATE products_stock SET ProductID=@ProductID, SupplierID=@SupplierID, CurrencyID=@CurrencyID, CostPrice=@CostPrice, Description=@Description, Quantity=@Quantity, Available=@Available, Barcode=@Barcode, DateOfProduction=@DateOfProduction, ExpiryDate=@ExpiryDate, WerehouseID=@WerehouseID, SectionID=@SectionID, RowID=@RowID, ColumnID=@ColumnID WHERE ID={SelectedID};";
            }
            else
            {
                if (Globals.ifExist("products", "barcode", barcodeTb.Text) && barcodeTb.Text != "")
                {
                    MessageBox.Show("This Vat Number is alredy Exist");
                    return;
                }
                SQL = "INSERT INTO products_stock (ProductID, SupplierID, CurrencyID, CostPrice, Description, Quantity, Available, Barcode, DateOfProduction, ExpiryDate, WerehouseID, SectionID, RowID, ColumnID) VALUES(@ProductID, @SupplierID, @CurrencyID, @CostPrice, @Description, @Quantity, @Available, @Barcode, @DateOfProduction, @ExpiryDate, @WerehouseID, @SectionID, @RowID, @ColumnID);";
            }

            myPara.Add("@ProductID", Globals.GetIdByString("products", "NameEn", productCb.Text));
            myPara.Add("@SupplierID", Globals.GetIdByString("suppliers", "NameEn", supplaierCb.Text));
            myPara.Add("@CurrencyID", Globals.GetIdByString("currencies", "Shortcut", currencyCb.Text));
            myPara.Add("@CostPrice", costPriceTb.Value);
            myPara.Add("@Description", DescriptionTb.Text);
            myPara.Add("@Quantity", quantTb.Value);
            myPara.Add("@Available", AvailableCb.Text == "Yes" ? true : false);
            myPara.Add("@Barcode", barcodeTb.Text);
            myPara.Add("@DateOfProduction", ProductionDate.Value);
            myPara.Add("@ExpiryDate", ExpiryDate.Value);

            myPara.Add("@WerehouseID", Globals.GetIdByString("warehouses", "NameEn", WerehouseCb.Text));
            myPara.Add("@SectionID", Globals.GetIdByString("nav_sections", "NameEn", SectionCb.Text));
            myPara.Add("@RowID", Globals.GetIdByString("nav_rows", "NameEn", RowCb.Text));
            myPara.Add("@ColumnID", Globals.GetIdByString("nav_columns", "NameEn", ColumnCb.Text));

            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);


        }

        private void addCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV1 window = new DefaultsDGV1("currencies");
            window.ShowDialog();
            Globals.refreshCb(currencyCb, "currencies", "Shortcut");
        }
        private void addEditProductB_Click(object sender, EventArgs e)
        {
            ProductsInfoDGV window = new ProductsInfoDGV();
            window.ShowDialog();
            Globals.refreshCb(productCb, "products", "NameEn");
        }

        private void addEditSupplierB_Click(object sender, EventArgs e)
        {
            SuppliersDGV window = new SuppliersDGV();
            window.ShowDialog();
            Globals.refreshCb(supplaierCb, "suppliers", "NameEn");
        }
    }
}
