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
namespace Market.AddEditOther.Product
{
    public partial class AddEditProducts : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable = "products";
        public int SelectedID;
        public string command;
        public Dictionary<string, int> CurrenciesCol = new Dictionary<string, int>();
        public Dictionary<string, int> UnitsValueCol = new Dictionary<string, int>();
        public Dictionary<string, int> ProductsGroubCol = new Dictionary<string, int>();
        public Dictionary<string, int> ProductsTypeCol = new Dictionary<string, int>();

        public AddEditProducts()
        {
            InitializeComponent();
        }


        public AddEditProducts(string conf, int id)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;

            CurrenciesCol = Globals.GetColumnsIndex("currencies");
            UnitsValueCol = Globals.GetColumnsIndex("units_value");
            ProductsGroubCol = Globals.GetColumnsIndex("products_groub");
            ProductsTypeCol = Globals.GetColumnsIndex("products_type");

            refreshCb(unitValueCb, "units_value");
            refreshCb(unitValueCb, "currencies");
            refreshCb(unitValueCb, "products_groub");
            refreshCb(unitValueCb, "products_type");


            if (command == "edit")
            {
                Text = "Edit Product Wizerd";
                AddEditBT.Text = "Edit";
                string SQL = $@"SELECT products_groub.NameEn AS groub, products_type.NameEn AS type, products.NameEn, products.NameAr, Size, units_value.Sortcut AS unit, Price, currencies.Sortcut AS Currency, Barcode, IncludeVat, IncludePrescription, UPC, SKU, ISBN From products INNER JOIN ON ";
            }
            else
            {
                Text = "Add Product Wizerd";
                AddEditBT.Text = "Add";

            }
        }

        private void AddEditBT_Click(object sender, EventArgs e)
        {

        }
        private void addUnitValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV1 window = new DefaultsDGV1("units_value");
            window.ShowDialog();
            refreshCb(unitValueCb, "units_value");
        }

        private void addCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV1 window = new DefaultsDGV1("currencies");
            window.ShowDialog();
            refreshCb(unitValueCb, "currencies");
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV2 window = new DefaultsDGV2("products_groub");
            window.ShowDialog();
            refreshCb(unitValueCb, "products_groub");
        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultsDGV2 window = new DefaultsDGV2("products_type");
            window.ShowDialog();
            refreshCb(unitValueCb, "products_type");
        }


        public void refreshCb(ComboBox obj, string table)
        {
            obj.Items.Clear();
            string SQL = $@"SELECT NameEn FROM {table}";
            using (MySqlDataReader dr = Globals.myCrud.getDrPassSql(SQL))
            {
                while (dr.Read())
                    obj.Items.Add(dr.GetString("NameEn"));
            }
        }
    }
}
