
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
            this.ProductNameEnCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomerCb = new System.Windows.Forms.ComboBox();
            this.PaidAmountTb = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.DiscountValueTb = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TotalDiscountL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalTotalL = new System.Windows.Forms.Label();
            this.TotalVATL = new System.Windows.Forms.Label();
            this.RemainL = new System.Windows.Forms.Label();
            this.PaidL = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LBAA = new System.Windows.Forms.Label();
            this.VATL = new System.Windows.Forms.Label();
            this.TotalL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DiscountL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.process1 = new System.Diagnostics.Process();
            this.SubmitB = new MaterialSkin.Controls.MaterialButton();
            this.Preview = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaidAmountTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountValueTb)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameEnCol,
            this.QuantityCol,
            this.UnitValueCol,
            this.SizeCol,
            this.PriceCol,
            this.ExpiryDateCol,
            this.BarcodeCol});
            this.dataGridView1.Location = new System.Drawing.Point(6, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductNameEnCol
            // 
            this.ProductNameEnCol.HeaderText = "En Name";
            this.ProductNameEnCol.Name = "ProductNameEnCol";
            this.ProductNameEnCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductNameEnCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuantityCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UnitValueCol
            // 
            this.UnitValueCol.HeaderText = "Unit Value";
            this.UnitValueCol.Name = "UnitValueCol";
            this.UnitValueCol.ReadOnly = true;
            // 
            // SizeCol
            // 
            this.SizeCol.HeaderText = "Size";
            this.SizeCol.Name = "SizeCol";
            this.SizeCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.DataPropertyName = "Price";
            this.PriceCol.HeaderText = "Price";
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // ExpiryDateCol
            // 
            this.ExpiryDateCol.DataPropertyName = "ExpiryDate";
            this.ExpiryDateCol.HeaderText = "Expire at";
            this.ExpiryDateCol.Name = "ExpiryDateCol";
            this.ExpiryDateCol.ReadOnly = true;
            // 
            // BarcodeCol
            // 
            this.BarcodeCol.DataPropertyName = "Barcode";
            this.BarcodeCol.HeaderText = "Barcode";
            this.BarcodeCol.Name = "BarcodeCol";
            this.BarcodeCol.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CustomerCb);
            this.groupBox2.Controls.Add(this.PaidAmountTb);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.DiscountValueTb);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // CustomerCb
            // 
            this.CustomerCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCb.FormattingEnabled = true;
            this.CustomerCb.Location = new System.Drawing.Point(106, 26);
            this.CustomerCb.Name = "CustomerCb";
            this.CustomerCb.Size = new System.Drawing.Size(174, 30);
            this.CustomerCb.TabIndex = 10;
            // 
            // PaidAmountTb
            // 
            this.PaidAmountTb.Location = new System.Drawing.Point(132, 62);
            this.PaidAmountTb.Name = "PaidAmountTb";
            this.PaidAmountTb.Size = new System.Drawing.Size(148, 30);
            this.PaidAmountTb.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 22);
            this.label19.TabIndex = 8;
            this.label19.Text = "Paid Amout:";
            // 
            // DiscountValueTb
            // 
            this.DiscountValueTb.Location = new System.Drawing.Point(132, 98);
            this.DiscountValueTb.Name = "DiscountValueTb";
            this.DiscountValueTb.Size = new System.Drawing.Size(148, 30);
            this.DiscountValueTb.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 100);
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
            this.label6.Location = new System.Drawing.Point(272, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Paid:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TotalDiscountL);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.FinalTotalL);
            this.groupBox3.Controls.Add(this.TotalVATL);
            this.groupBox3.Controls.Add(this.RemainL);
            this.groupBox3.Controls.Add(this.PaidL);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.LBAA);
            this.groupBox3.Controls.Add(this.VATL);
            this.groupBox3.Controls.Add(this.TotalL);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.DiscountL);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.splitter1);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(298, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 157);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // TotalDiscountL
            // 
            this.TotalDiscountL.AutoSize = true;
            this.TotalDiscountL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountL.Location = new System.Drawing.Point(163, 74);
            this.TotalDiscountL.Name = "TotalDiscountL";
            this.TotalDiscountL.Size = new System.Drawing.Size(50, 22);
            this.TotalDiscountL.TabIndex = 25;
            this.TotalDiscountL.Text = "test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(270, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Final Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(252, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Discount:";
            // 
            // FinalTotalL
            // 
            this.FinalTotalL.AutoSize = true;
            this.FinalTotalL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTotalL.Location = new System.Drawing.Point(305, 60);
            this.FinalTotalL.Name = "FinalTotalL";
            this.FinalTotalL.Size = new System.Drawing.Size(50, 22);
            this.FinalTotalL.TabIndex = 18;
            this.FinalTotalL.Text = "test";
            // 
            // TotalVATL
            // 
            this.TotalVATL.AutoSize = true;
            this.TotalVATL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVATL.Location = new System.Drawing.Point(114, 118);
            this.TotalVATL.Name = "TotalVATL";
            this.TotalVATL.Size = new System.Drawing.Size(50, 22);
            this.TotalVATL.TabIndex = 23;
            this.TotalVATL.Text = "test";
            // 
            // RemainL
            // 
            this.RemainL.AutoSize = true;
            this.RemainL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainL.Location = new System.Drawing.Point(338, 112);
            this.RemainL.Name = "RemainL";
            this.RemainL.Size = new System.Drawing.Size(50, 22);
            this.RemainL.TabIndex = 16;
            this.RemainL.Text = "test";
            // 
            // PaidL
            // 
            this.PaidL.AutoSize = true;
            this.PaidL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidL.Location = new System.Drawing.Point(338, 90);
            this.PaidL.Name = "PaidL";
            this.PaidL.Size = new System.Drawing.Size(50, 22);
            this.PaidL.TabIndex = 17;
            this.PaidL.Text = "test";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 22);
            this.label18.TabIndex = 22;
            this.label18.Text = "Total VAT:";
            // 
            // LBAA
            // 
            this.LBAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBAA.AutoSize = true;
            this.LBAA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAA.Location = new System.Drawing.Point(6, 29);
            this.LBAA.Name = "LBAA";
            this.LBAA.Size = new System.Drawing.Size(70, 22);
            this.LBAA.TabIndex = 7;
            this.LBAA.Text = "Total:";
            // 
            // VATL
            // 
            this.VATL.AutoSize = true;
            this.VATL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VATL.Location = new System.Drawing.Point(58, 96);
            this.VATL.Name = "VATL";
            this.VATL.Size = new System.Drawing.Size(50, 22);
            this.VATL.TabIndex = 19;
            this.VATL.Text = "test";
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.Location = new System.Drawing.Point(82, 30);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(50, 22);
            this.TotalL.TabIndex = 21;
            this.TotalL.Text = "test";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "VAT:";
            // 
            // DiscountL
            // 
            this.DiscountL.AutoSize = true;
            this.DiscountL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountL.Location = new System.Drawing.Point(107, 52);
            this.DiscountL.Name = "DiscountL";
            this.DiscountL.Size = new System.Drawing.Size(50, 22);
            this.DiscountL.TabIndex = 20;
            this.DiscountL.Text = "test";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Discount:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(243, 128);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
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
            this.addProductToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(3, 538);
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
            this.SubmitB.Location = new System.Drawing.Point(625, 496);
            this.SubmitB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SubmitB.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SubmitB.Size = new System.Drawing.Size(73, 36);
            this.SubmitB.TabIndex = 11;
            this.SubmitB.Text = "Submit";
            this.SubmitB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SubmitB.UseAccentColor = false;
            this.SubmitB.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Preview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Preview.Depth = 0;
            this.Preview.HighEmphasis = true;
            this.Preview.Icon = null;
            this.Preview.Location = new System.Drawing.Point(536, 496);
            this.Preview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Preview.MouseState = MaterialSkin.MouseState.HOVER;
            this.Preview.Name = "Preview";
            this.Preview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Preview.Size = new System.Drawing.Size(81, 36);
            this.Preview.TabIndex = 12;
            this.Preview.Text = "Preview";
            this.Preview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Preview.UseAccentColor = false;
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 563);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewInvoiceForm";
            this.Sizable = false;
            this.Text = "NewInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBAA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.Label DiscountL;
        private System.Windows.Forms.Label VATL;
        private System.Windows.Forms.Label FinalTotalL;
        private System.Windows.Forms.Label PaidL;
        private System.Windows.Forms.Label RemainL;
        private System.Windows.Forms.ComboBox CustomerCb;
        private System.Windows.Forms.NumericUpDown PaidAmountTb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown DiscountValueTb;
        private System.Windows.Forms.Label TotalVATL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label TotalDiscountL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductNameEnCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitValueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeCol;
        private MaterialSkin.Controls.MaterialButton SubmitB;
        private MaterialSkin.Controls.MaterialButton Preview;
    }
}