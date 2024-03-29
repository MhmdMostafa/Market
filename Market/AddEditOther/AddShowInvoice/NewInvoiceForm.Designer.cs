﻿
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductNameEnCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InvoiceTypeCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerCb = new System.Windows.Forms.ComboBox();
            this.PaidAmountTb = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.DiscountValueTb = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TotalAfterDiscountL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FinalTotalL = new System.Windows.Forms.Label();
            this.TotalVATL = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LBAA = new System.Windows.Forms.Label();
            this.VATL = new System.Windows.Forms.Label();
            this.PaidL = new System.Windows.Forms.Label();
            this.TotalL = new System.Windows.Forms.Label();
            this.RemainL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditValueL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerB = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.process1 = new System.Diagnostics.Process();
            this.SubmitB = new MaterialSkin.Controls.MaterialButton();
            this.SelectAllCB = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaymentMethodCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currencyCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaidAmountTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountValueTb)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.ProductNameEnCol,
            this.QuantityCol,
            this.Price,
            this.Size,
            this.UnitValue,
            this.ExpiryDate,
            this.Barcode});
            this.dataGridView.Location = new System.Drawing.Point(6, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(698, 218);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // c1
            // 
            this.c1.HeaderText = "";
            this.c1.Name = "c1";
            this.c1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c1.Width = 30;
            // 
            // ProductNameEnCol
            // 
            this.ProductNameEnCol.HeaderText = "Product Name";
            this.ProductNameEnCol.Name = "ProductNameEnCol";
            this.ProductNameEnCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductNameEnCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // UnitValue
            // 
            this.UnitValue.DataPropertyName = "UnitValue";
            this.UnitValue.HeaderText = "Unit Value";
            this.UnitValue.Name = "UnitValue";
            this.UnitValue.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "Expiry Date";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.currencyCb);
            this.groupBox2.Controls.Add(this.PaymentMethodCb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.InvoiceTypeCb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CustomerCb);
            this.groupBox2.Controls.Add(this.PaidAmountTb);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.DiscountValueTb);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 234);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // InvoiceTypeCb
            // 
            this.InvoiceTypeCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.InvoiceTypeCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.InvoiceTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvoiceTypeCb.FormattingEnabled = true;
            this.InvoiceTypeCb.Location = new System.Drawing.Point(72, 26);
            this.InvoiceTypeCb.Name = "InvoiceTypeCb";
            this.InvoiceTypeCb.Size = new System.Drawing.Size(208, 30);
            this.InvoiceTypeCb.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type:";
            // 
            // CustomerCb
            // 
            this.CustomerCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCb.FormattingEnabled = true;
            this.CustomerCb.Location = new System.Drawing.Point(106, 61);
            this.CustomerCb.Name = "CustomerCb";
            this.CustomerCb.Size = new System.Drawing.Size(174, 30);
            this.CustomerCb.TabIndex = 10;
            // 
            // PaidAmountTb
            // 
            this.PaidAmountTb.DecimalPlaces = 2;
            this.PaidAmountTb.Location = new System.Drawing.Point(121, 169);
            this.PaidAmountTb.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.PaidAmountTb.Name = "PaidAmountTb";
            this.PaidAmountTb.Size = new System.Drawing.Size(86, 30);
            this.PaidAmountTb.TabIndex = 9;
            this.PaidAmountTb.ValueChanged += new System.EventHandler(this.PaidAmountTb_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 22);
            this.label19.TabIndex = 8;
            this.label19.Text = "Paid Amout:";
            // 
            // DiscountValueTb
            // 
            this.DiscountValueTb.DecimalPlaces = 2;
            this.DiscountValueTb.Location = new System.Drawing.Point(132, 133);
            this.DiscountValueTb.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.DiscountValueTb.Name = "DiscountValueTb";
            this.DiscountValueTb.Size = new System.Drawing.Size(148, 30);
            this.DiscountValueTb.TabIndex = 7;
            this.DiscountValueTb.ValueChanged += new System.EventHandler(this.DiscountValueTb_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "Discount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Paid:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TotalAfterDiscountL);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.FinalTotalL);
            this.groupBox3.Controls.Add(this.TotalVATL);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.LBAA);
            this.groupBox3.Controls.Add(this.VATL);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PaidL);
            this.groupBox3.Controls.Add(this.TotalL);
            this.groupBox3.Controls.Add(this.RemainL);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CreditValueL);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(298, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 213);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // TotalAfterDiscountL
            // 
            this.TotalAfterDiscountL.AutoSize = true;
            this.TotalAfterDiscountL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAfterDiscountL.Location = new System.Drawing.Point(160, 49);
            this.TotalAfterDiscountL.Name = "TotalAfterDiscountL";
            this.TotalAfterDiscountL.Size = new System.Drawing.Size(50, 22);
            this.TotalAfterDiscountL.TabIndex = 38;
            this.TotalAfterDiscountL.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "After Discount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "Final Total:";
            // 
            // FinalTotalL
            // 
            this.FinalTotalL.AutoSize = true;
            this.FinalTotalL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTotalL.Location = new System.Drawing.Point(133, 117);
            this.FinalTotalL.Name = "FinalTotalL";
            this.FinalTotalL.Size = new System.Drawing.Size(50, 22);
            this.FinalTotalL.TabIndex = 32;
            this.FinalTotalL.Text = "test";
            // 
            // TotalVATL
            // 
            this.TotalVATL.AutoSize = true;
            this.TotalVATL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVATL.Location = new System.Drawing.Point(111, 93);
            this.TotalVATL.Name = "TotalVATL";
            this.TotalVATL.Size = new System.Drawing.Size(50, 22);
            this.TotalVATL.TabIndex = 36;
            this.TotalVATL.Text = "test";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 22);
            this.label18.TabIndex = 35;
            this.label18.Text = "Total VAT:";
            // 
            // LBAA
            // 
            this.LBAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBAA.AutoSize = true;
            this.LBAA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAA.Location = new System.Drawing.Point(6, 26);
            this.LBAA.Name = "LBAA";
            this.LBAA.Size = new System.Drawing.Size(70, 22);
            this.LBAA.TabIndex = 30;
            this.LBAA.Text = "Total:";
            // 
            // VATL
            // 
            this.VATL.AutoSize = true;
            this.VATL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VATL.Location = new System.Drawing.Point(55, 71);
            this.VATL.Name = "VATL";
            this.VATL.Size = new System.Drawing.Size(50, 22);
            this.VATL.TabIndex = 33;
            this.VATL.Text = "test";
            // 
            // PaidL
            // 
            this.PaidL.AutoSize = true;
            this.PaidL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidL.Location = new System.Drawing.Point(72, 137);
            this.PaidL.Name = "PaidL";
            this.PaidL.Size = new System.Drawing.Size(50, 22);
            this.PaidL.TabIndex = 17;
            this.PaidL.Text = "test";
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.Location = new System.Drawing.Point(82, 27);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(50, 22);
            this.TotalL.TabIndex = 34;
            this.TotalL.Text = "test";
            // 
            // RemainL
            // 
            this.RemainL.AutoSize = true;
            this.RemainL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainL.Location = new System.Drawing.Point(92, 159);
            this.RemainL.Name = "RemainL";
            this.RemainL.Size = new System.Drawing.Size(50, 22);
            this.RemainL.TabIndex = 16;
            this.RemainL.Text = "test";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "VAT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Credit:";
            // 
            // CreditValueL
            // 
            this.CreditValueL.AutoSize = true;
            this.CreditValueL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditValueL.Location = new System.Drawing.Point(92, 183);
            this.CreditValueL.Name = "CreditValueL";
            this.CreditValueL.Size = new System.Drawing.Size(50, 22);
            this.CreditValueL.TabIndex = 28;
            this.CreditValueL.Text = "test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remain:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.AddCustomerB});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // AddCustomerB
            // 
            this.AddCustomerB.Name = "AddCustomerB";
            this.AddCustomerB.Size = new System.Drawing.Size(200, 26);
            this.AddCustomerB.Text = "Add Customer";
            this.AddCustomerB.Click += new System.EventHandler(this.AddCustomerB_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(3, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // SubmitB
            // 
            this.SubmitB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SubmitB.Depth = 0;
            this.SubmitB.HighEmphasis = true;
            this.SubmitB.Icon = null;
            this.SubmitB.Location = new System.Drawing.Point(579, 504);
            this.SubmitB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SubmitB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SubmitB.Size = new System.Drawing.Size(75, 36);
            this.SubmitB.TabIndex = 11;
            this.SubmitB.Text = "Submit";
            this.SubmitB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SubmitB.UseAccentColor = false;
            this.SubmitB.UseVisualStyleBackColor = true;
            this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click);
            // 
            // SelectAllCB
            // 
            this.SelectAllCB.AutoSize = true;
            this.SelectAllCB.Location = new System.Drawing.Point(56, 101);
            this.SelectAllCB.Name = "SelectAllCB";
            this.SelectAllCB.Size = new System.Drawing.Size(15, 14);
            this.SelectAllCB.TabIndex = 33;
            this.SelectAllCB.UseVisualStyleBackColor = true;
            this.SelectAllCB.CheckedChanged += new System.EventHandler(this.SelectAllCB_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(526, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentMethodCb
            // 
            this.PaymentMethodCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PaymentMethodCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PaymentMethodCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodCb.FormattingEnabled = true;
            this.PaymentMethodCb.Location = new System.Drawing.Point(92, 97);
            this.PaymentMethodCb.Name = "PaymentMethodCb";
            this.PaymentMethodCb.Size = new System.Drawing.Size(188, 30);
            this.PaymentMethodCb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Method:";
            // 
            // currencyCb
            // 
            this.currencyCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.currencyCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.currencyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyCb.FormattingEnabled = true;
            this.currencyCb.Location = new System.Drawing.Point(213, 169);
            this.currencyCb.Name = "currencyCb";
            this.currencyCb.Size = new System.Drawing.Size(67, 30);
            this.currencyCb.TabIndex = 15;
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SelectAllCB);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewInvoiceForm";
            this.Sizable = false;
            this.Text = "NewInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaidAmountTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountValueTb)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label PaidL;
        private System.Windows.Forms.Label RemainL;
        private System.Windows.Forms.ComboBox CustomerCb;
        private System.Windows.Forms.NumericUpDown PaidAmountTb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown DiscountValueTb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Diagnostics.Process process1;
        private MaterialSkin.Controls.MaterialButton SubmitB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreditValueL;
        private System.Windows.Forms.Label TotalAfterDiscountL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalVATL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LBAA;
        private System.Windows.Forms.Label VATL;
        private System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FinalTotalL;
        private System.Windows.Forms.CheckBox SelectAllCB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductNameEnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.ComboBox InvoiceTypeCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox PaymentMethodCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox currencyCb;
    }
}
