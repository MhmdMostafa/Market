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
    public partial class MainForm : Form
    {
        public static bool FlagOpendWindow = false;
        private Form ChiledWindow = null;
        public MainForm()
        {
            InitializeComponent();
        }
         
        public void OptionsMenuB_Click(object sender, EventArgs e)
        {
            FlagOpendWindow = true;
            ChiledWindow = new OptionsForm(this);
            ChiledWindow.Show();
        }
        protected override void OnActivated(EventArgs e)
        {
            if (FlagOpendWindow)
                ChiledWindow.Activate();
        }

    }
}
