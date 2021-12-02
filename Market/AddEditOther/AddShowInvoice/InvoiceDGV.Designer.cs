
namespace Market
{
    partial class InvoiceDGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectAllCb = new System.Windows.Forms.CheckBox();
            this.ShowInv = new MaterialSkin.Controls.MaterialButton();
            this.AddB = new MaterialSkin.Controls.MaterialButton();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectAllCb
            // 
            this.SelectAllCb.AutoSize = true;
            this.SelectAllCb.Location = new System.Drawing.Point(51, 70);
            this.SelectAllCb.Name = "SelectAllCb";
            this.SelectAllCb.Size = new System.Drawing.Size(15, 14);
            this.SelectAllCb.TabIndex = 28;
            this.SelectAllCb.UseVisualStyleBackColor = true;
            this.SelectAllCb.CheckedChanged += new System.EventHandler(this.SelectAllCb_CheckedChanged);
            // 
            // ShowInv
            // 
            this.ShowInv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowInv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowInv.Depth = 0;
            this.ShowInv.HighEmphasis = true;
            this.ShowInv.Icon = null;
            this.ShowInv.Location = new System.Drawing.Point(598, 390);
            this.ShowInv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowInv.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowInv.Name = "ShowInv";
            this.ShowInv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowInv.Size = new System.Drawing.Size(64, 36);
            this.ShowInv.TabIndex = 27;
            this.ShowInv.Text = "Edit";
            this.ShowInv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowInv.UseAccentColor = false;
            this.ShowInv.UseVisualStyleBackColor = true;
            this.ShowInv.Click += new System.EventHandler(this.ShowInv_Click);
            // 
            // AddB
            // 
            this.AddB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddB.Depth = 0;
            this.AddB.HighEmphasis = true;
            this.AddB.Icon = null;
            this.AddB.Location = new System.Drawing.Point(670, 390);
            this.AddB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddB.Name = "AddB";
            this.AddB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddB.Size = new System.Drawing.Size(64, 36);
            this.AddB.TabIndex = 26;
            this.AddB.Text = "Add";
            this.AddB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddB.UseAccentColor = false;
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToAddRows = false;
            this.ProductsDGV.AllowUserToDeleteRows = false;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.ProductsDGV.Location = new System.Drawing.Point(6, 67);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.Size = new System.Drawing.Size(729, 314);
            this.ProductsDGV.TabIndex = 25;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // InvoiceDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.SelectAllCb);
            this.Controls.Add(this.ShowInv);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.ProductsDGV);
            this.Name = "InvoiceDGV";
            this.Sizable = false;
            this.Text = "ProductsInfoDGV";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SelectAllCb;
        private MaterialSkin.Controls.MaterialButton ShowInv;
        private MaterialSkin.Controls.MaterialButton AddB;
        private System.Windows.Forms.DataGridView ProductsDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
