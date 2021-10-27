
namespace Market
{
    partial class NewInvoiceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InvoiceIdL = new System.Windows.Forms.Label();
            this.DateL = new System.Windows.Forms.Label();
            this.SellerL = new System.Windows.Forms.Label();
            this.CustomrL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBAA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ProductIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameEnCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDCol,
            this.ProductNameEnCol,
            this.QuantityCol,
            this.PriceCol,
            this.SizeCol,
            this.UnitValueCol,
            this.ExpiryDateCol,
            this.BarcodeCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomrL);
            this.groupBox1.Controls.Add(this.SellerL);
            this.groupBox1.Controls.Add(this.DateL);
            this.groupBox1.Controls.Add(this.InvoiceIdL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice info:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer:";
            // 
            // InvoiceIdL
            // 
            this.InvoiceIdL.AutoSize = true;
            this.InvoiceIdL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceIdL.Location = new System.Drawing.Point(112, 26);
            this.InvoiceIdL.Name = "InvoiceIdL";
            this.InvoiceIdL.Size = new System.Drawing.Size(50, 22);
            this.InvoiceIdL.TabIndex = 4;
            this.InvoiceIdL.Text = "test";
            // 
            // DateL
            // 
            this.DateL.AutoSize = true;
            this.DateL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateL.Location = new System.Drawing.Point(112, 48);
            this.DateL.Name = "DateL";
            this.DateL.Size = new System.Drawing.Size(50, 22);
            this.DateL.TabIndex = 5;
            this.DateL.Text = "test";
            // 
            // SellerL
            // 
            this.SellerL.AutoSize = true;
            this.SellerL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerL.Location = new System.Drawing.Point(112, 70);
            this.SellerL.Name = "SellerL";
            this.SellerL.Size = new System.Drawing.Size(50, 22);
            this.SellerL.TabIndex = 6;
            this.SellerL.Text = "test";
            // 
            // CustomrL
            // 
            this.CustomrL.AutoSize = true;
            this.CustomrL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomrL.Location = new System.Drawing.Point(112, 92);
            this.CustomrL.Name = "CustomrL";
            this.CustomrL.Size = new System.Drawing.Size(50, 22);
            this.CustomrL.TabIndex = 7;
            this.CustomrL.Text = "test";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 188);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Paid:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LBAA);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(304, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 188);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remain:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total:";
            // 
            // LBAA
            // 
            this.LBAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBAA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAA.Location = new System.Drawing.Point(6, 26);
            this.LBAA.Name = "LBAA";
            this.LBAA.Size = new System.Drawing.Size(178, 44);
            this.LBAA.TabIndex = 7;
            this.LBAA.Text = " Total amount Excluding VAT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "VAT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Discount:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "Discount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(150, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 22);
            this.label15.TabIndex = 21;
            this.label15.Text = "test";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(150, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 22);
            this.label14.TabIndex = 20;
            this.label14.Text = "test";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(150, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "test";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "test";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "test";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(106, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 22);
            this.label17.TabIndex = 22;
            this.label17.Text = "test";
            // 
            // ProductIDCol
            // 
            this.ProductIDCol.HeaderText = "ID";
            this.ProductIDCol.Name = "ProductIDCol";
            this.ProductIDCol.ReadOnly = true;
            // 
            // ProductNameEnCol
            // 
            this.ProductNameEnCol.HeaderText = "En Name";
            this.ProductNameEnCol.Name = "ProductNameEnCol";
            this.ProductNameEnCol.ReadOnly = true;
            this.ProductNameEnCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductNameEnCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            // 
            // PriceCol
            // 
            this.PriceCol.HeaderText = "Price";
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // SizeCol
            // 
            this.SizeCol.HeaderText = "Size";
            this.SizeCol.Name = "SizeCol";
            this.SizeCol.ReadOnly = true;
            // 
            // UnitValueCol
            // 
            this.UnitValueCol.HeaderText = "Unit Value";
            this.UnitValueCol.Name = "UnitValueCol";
            this.UnitValueCol.ReadOnly = true;
            // 
            // ExpiryDateCol
            // 
            this.ExpiryDateCol.HeaderText = "Expire at";
            this.ExpiryDateCol.Name = "ExpiryDateCol";
            this.ExpiryDateCol.ReadOnly = true;
            // 
            // BarcodeCol
            // 
            this.BarcodeCol.HeaderText = "Barcode";
            this.BarcodeCol.Name = "BarcodeCol";
            this.BarcodeCol.ReadOnly = true;
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewInvoiceForm";
            this.Text = "NewInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label InvoiceIdL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomrL;
        private System.Windows.Forms.Label SellerL;
        private System.Windows.Forms.Label DateL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBAA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductNameEnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitValueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeCol;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}