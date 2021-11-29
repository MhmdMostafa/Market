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
    public partial class MainProduct : MaterialSkin.Controls.MaterialForm
    {
        public string SQLtable = "products";
        public int SelectedID;
        public string command;
        public MainProduct()
        {
            InitializeComponent();
        }

        public MainProduct(string conf, int id)
        {
            InitializeComponent();
            command = conf;
            SelectedID = id;




            if (command == "edit")
            {
                Text = "Edit Product Wizerd";
            }
            else
            {
                Text = "Add Product Wizerd";

            }
        }
    }
}
