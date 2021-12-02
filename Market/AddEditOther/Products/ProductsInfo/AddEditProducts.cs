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
    public partial class AddEditProducts : MaterialSkin.Controls.MaterialForm
    {
        public int SelectedID;
        public string command;
        public Dictionary<string, int> ProductsCol = new Dictionary<string, int>();
        public Dictionary<string, int> CurrenciesCol = new Dictionary<string, int>();
        public Dictionary<string, int> UnitsValueCol = new Dictionary<string, int>();
        public Dictionary<string, int> ProductsGroubCol = new Dictionary<string, int>();
        public Dictionary<string, int> ProductsTypeCol = new Dictionary<string, int>();
        public AddEditProducts()
        {
            InitializeComponent();
        }


        public AddEditProducts(string conf, int id = 0)
        {

            InitializeComponent();
            command = conf;
            SelectedID = id;

            ProductsCol = Globals.GetColumnsIndex("products");
            CurrenciesCol = Globals.GetColumnsIndex("currencies");
            UnitsValueCol = Globals.GetColumnsIndex("units_value");
            ProductsGroubCol = Globals.GetColumnsIndex("products_groub");
            ProductsTypeCol = Globals.GetColumnsIndex("products_type");

            Globals.refreshCb(unitValueCb, "units_value", "Shortcut");
            Globals.refreshCb(currencyCb, "currencies", "Shortcut");
            Globals.refreshCb(groubCb, "products_groub", "NameEn");
            Globals.refreshCb(typeCb, "products_type", "NameEn");
            vatCb.SelectedIndex = 1;
            prescriptionCb.SelectedIndex = 1;

            if (command == "edit")
            {
                Text = "Edit Product Wizerd";
                AddEditBT.Text = "Edit";
                string SQL = $@"SELECT products.ID, products_groub.NameEn AS Groub, products_type.NameEn AS Type, products.NameEn, products.NameAr, Size, units_value.Shortcut AS Unit, Price, currencies.Shortcut AS Currency, Barcode, IncludeVat, IncludePrescription, UPC, SKU, ISBN From products INNER JOIN products_groub ON ProductGroubID = products_groub.ID INNER JOIN products_type ON ProductTypeID = products_type.ID INNER JOIN units_value ON UnitValueID = units_value.ID INNER JOIN currencies ON CurrencyID = currencies.ID;";

                using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
                {
                    dr.Read();
                    nameEnTb.Text = dr.IsDBNull(ProductsCol["NameEn"]) ? "" : dr.GetString("NameEn");
                    nameArTb.Text = dr.IsDBNull(ProductsCol["NameAr"]) ? "" : dr.GetString("NameAr");
                    groubCb.SelectedItem = dr.IsDBNull(ProductsCol["ProductGroubID"]) ? "" : dr.GetString("Groub");
                    typeCb.Text = dr.IsDBNull(ProductsCol["ProductTypeID"]) ? "" : dr.GetString("Type");
                    sizeTb.Value = dr.IsDBNull(ProductsCol["Size"]) ? 0 : (decimal)dr.GetFloat("Size");
                    unitValueCb.SelectedItem = dr.IsDBNull(ProductsCol["UnitValueID"]) ? "" : dr.GetString("Unit");
                    salePriceTb.Value = dr.IsDBNull(ProductsCol["Price"]) ? 0 : (decimal)dr.GetFloat("Price");
                    currencyCb.SelectedItem = dr.IsDBNull(ProductsCol["CurrencyID"]) ? "" : dr.GetString("Currency");
                    barcodeTb.Text = dr.IsDBNull(ProductsCol["Barcode"]) ? "" : dr.GetString("Barcode");
                    upcTb.Text = dr.IsDBNull(ProductsCol["UPC"]) ? "" : dr.GetString("UPC");
                    skuTb.Text = dr.IsDBNull(ProductsCol["SKU"]) ? "" : dr.GetString("SKU");
                    isbnTb.Text = dr.IsDBNull(ProductsCol["ISBN"]) ? "" : dr.GetString("ISBN");
                    prescriptionCb.SelectedItem = dr.IsDBNull(ProductsCol["IncludePrescription"]) ? "" : dr.GetString("IncludePrescription");
                    vatCb.SelectedItem = dr.IsDBNull(ProductsCol["IncludeVat"]) ? "" : dr.GetString("IncludeVat");
                }
            }
            else
            {
                Text = "Add Product Wizerd";
                AddEditBT.Text = "Add";
            }


        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            STATUS.Text = "Adding";
            progressBar1.Value = 10;
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            string SQL;
            Globals.CleanTB(Controls);



            if (nameEnTb.Text == "" || nameArTb.Text == "" || groubCb.Text == "" || typeCb.Text == "" || sizeTb.Text == "" || unitValueCb.Text == "" || salePriceTb.Text == "" || currencyCb.Text == "" || prescriptionCb.Text == "" || vatCb.Text == "")
            {
                MessageBox.Show("Please Fill all needed inf");
                return;
            }
            if (command == "edit")
            {
                if ((Globals.ifExist("products", "UPC", upcTb.Text) && upcTb.Text != "") || (Globals.ifExist("products", "SKU", skuTb.Text) && skuTb.Text != "") || (Globals.ifExist("products", "ISBN", isbnTb.Text) && isbnTb.Text != "") || (Globals.ifExist("products", "barcode", barcodeTb.Text) && barcodeTb.Text != ""))
                {
                    MessageBox.Show("This product is alredy Exist");
                    return;
                }
                SQL = $"UPDATE products SET NameEn=@NameEn, NameAr=@NameAr, ProductGroubID=@ProductGroubID, ProductTypeID=@ProductTypeID, Size=@Size, UnitValueID=@UnitValueID, Price=@Price, CurrencyID=@CurrencyID, Barcode=@Barcode, UPC=@UPC, SKU=@SKU, ISBN=@ISBN, IncludePrescription=@IncludePrescription, IncludeVat=@IncludeVat WHERE ID={SelectedID};";
            }
            else
            {
                if ((Globals.ifExist("products", "UPC", upcTb.Text) && upcTb.Text != "") || (Globals.ifExist("products", "SKU", skuTb.Text) && skuTb.Text != "") || (Globals.ifExist("products", "ISBN", isbnTb.Text) && isbnTb.Text != "") || (Globals.ifExist("products", "barcode", barcodeTb.Text) && barcodeTb.Text != ""))
                {
                    MessageBox.Show("This product is alredy Exist");
                    return;
                }
                SQL = "INSERT INTO products (NameEn, NameAr, ProductGroubID, ProductTypeID, Size, UnitValueID, Price, CurrencyID, Barcode, UPC, SKU, ISBN, IncludePrescription, IncludeVat) VALUES(@NameEn, @NameAr, @ProductGroubID, @ProductTypeID, @Size, @UnitValueID, @Price, @CurrencyID, @Barcode, @UPC, @SKU, @ISBN, @IncludePrescription, @IncludeVat);";
            }

            myPara.Add("@NameEn", nameEnTb.Text);
            myPara.Add("@NameAr", nameArTb.Text);
            myPara.Add("@ProductGroubID", Globals.GetIdByString("products_groub", "NameEn", groubCb.Text));
            myPara.Add("@ProductTypeID", Globals.GetIdByString("products_type", "NameEn", typeCb.Text));
            myPara.Add("@Size", sizeTb.Value);
            myPara.Add("@UnitValueID", Globals.GetIdByString("units_value", "Shortcut", unitValueCb.Text));
            myPara.Add("@Price", salePriceTb.Value);
            myPara.Add("@CurrencyID", Globals.GetIdByString("currencies", "Shortcut", currencyCb.Text));
            myPara.Add("@Barcode", barcodeTb.Text);
            myPara.Add("@UPC", upcTb.Text);
            myPara.Add("@SKU", skuTb.Text);
            myPara.Add("@ISBN", isbnTb.Text);
            myPara.Add("@IncludePrescription", prescriptionCb.Text == "Yes" ? true : false);
            myPara.Add("@IncludeVat", vatCb.Text == "Yes" ? true : false);

            Globals.myCrud.InsertUpdateDeleteViaSqlDic(SQL, myPara);
            progressBar1.Value = 100;
            STATUS.Text = $"Added {nameEnTb.Text}";
            progressBar1.Value = 0;

        }

        private void addUnitValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV1 window = new DefaultsDGV1("units_value");
            window.ShowDialog();
            Globals.refreshCb(unitValueCb, "units_value", "Shortcut");
        }

        private void addCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV1 window = new DefaultsDGV1("currencies");
            window.ShowDialog();
            Globals.refreshCb(currencyCb, "currencies", "Shortcut");
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV2 window = new DefaultsDGV2("products_groub");
            window.ShowDialog();
            Globals.refreshCb(groubCb, "products_groub", "NameEn");
        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV2 window = new DefaultsDGV2("products_type");
            window.ShowDialog();
            Globals.refreshCb(typeCb, "products_type", "NameEn");
        }

    }
}
