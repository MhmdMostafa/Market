
namespace Market
{
    partial class WerehouseDGV
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
            this.EditB = new MaterialSkin.Controls.MaterialButton();
            this.AddB = new MaterialSkin.Controls.MaterialButton();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncludeVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncludePrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectAllCb
            // 
            this.SelectAllCb.AutoSize = true;
            this.SelectAllCb.Location = new System.Drawing.Point(49, 82);
            this.SelectAllCb.Name = "SelectAllCb";
            this.SelectAllCb.Size = new System.Drawing.Size(15, 14);
            this.SelectAllCb.TabIndex = 28;
            this.SelectAllCb.UseVisualStyleBackColor = true;
            this.SelectAllCb.CheckedChanged += new System.EventHandler(this.SelectAllCb_CheckedChanged);
            // 
            // EditB
            // 
            this.EditB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditB.Depth = 0;
            this.EditB.HighEmphasis = true;
            this.EditB.Icon = null;
            this.EditB.Location = new System.Drawing.Point(598, 390);
            this.EditB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditB.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditB.Name = "EditB";
            this.EditB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditB.Size = new System.Drawing.Size(64, 36);
            this.EditB.TabIndex = 27;
            this.EditB.Text = "Edit";
            this.EditB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditB.UseAccentColor = false;
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
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
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column1,
            this.CustomerGroup,
            this.CurrencyID,
            this.IncludeVat,
            this.IncludePrescription,
            this.Barcode,
            this.UPC,
            this.SKU,
            this.ISBN});
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameEn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name En";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameAr";
            this.dataGridViewTextBoxColumn3.HeaderText = "NameAr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductGroubID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Group";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductTypeID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn6.HeaderText = "Size";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UnitValueID";
            this.Column1.HeaderText = "Unit Value";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // CustomerGroup
            // 
            this.CustomerGroup.DataPropertyName = "Price";
            this.CustomerGroup.HeaderText = "Price";
            this.CustomerGroup.Name = "CustomerGroup";
            // 
            // CurrencyID
            // 
            this.CurrencyID.DataPropertyName = "CurrencyID";
            this.CurrencyID.HeaderText = "Currency";
            this.CurrencyID.Name = "CurrencyID";
            // 
            // IncludeVat
            // 
            this.IncludeVat.DataPropertyName = "IncludeVat";
            this.IncludeVat.HeaderText = "Include Vat";
            this.IncludeVat.Name = "IncludeVat";
            // 
            // IncludePrescription
            // 
            this.IncludePrescription.DataPropertyName = "IncludePrescription";
            this.IncludePrescription.HeaderText = "Include Prescription";
            this.IncludePrescription.Name = "IncludePrescription";
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // UPC
            // 
            this.UPC.DataPropertyName = "UPC";
            this.UPC.HeaderText = "UPC";
            this.UPC.Name = "UPC";
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // ProductsInfoDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.SelectAllCb);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.ProductsDGV);
            this.Name = "ProductsInfoDGV";
            this.Text = "ProductsInfoDGV";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SelectAllCb;
        private MaterialSkin.Controls.MaterialButton EditB;
        private MaterialSkin.Controls.MaterialButton AddB;
        private System.Windows.Forms.DataGridView ProductsDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncludeVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncludePrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
    }
}