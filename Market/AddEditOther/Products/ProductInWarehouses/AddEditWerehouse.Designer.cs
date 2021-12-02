
namespace Market
{
    partial class AddEditWerehouse
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
            this.costPriceTb = new System.Windows.Forms.NumericUpDown();
            this.currencyCb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditSupplierB = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditProductB = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEditBT = new MaterialSkin.Controls.MaterialButton();
            this.productCb = new System.Windows.Forms.ComboBox();
            this.supplaierCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddProduct = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.AvailableCb = new System.Windows.Forms.ComboBox();
            this.DescriptionTb = new System.Windows.Forms.RichTextBox();
            this.quantTb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label12 = new System.Windows.Forms.Label();
            this.ColumnCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RowCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SectionCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WerehouseCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.costPriceTb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantTb)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // costPriceTb
            // 
            this.costPriceTb.DecimalPlaces = 3;
            this.costPriceTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.costPriceTb.Location = new System.Drawing.Point(133, 118);
            this.costPriceTb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.costPriceTb.Name = "costPriceTb";
            this.costPriceTb.Size = new System.Drawing.Size(147, 30);
            this.costPriceTb.TabIndex = 114;
            // 
            // currencyCb
            // 
            this.currencyCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.currencyCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.currencyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyCb.FormattingEnabled = true;
            this.currencyCb.Location = new System.Drawing.Point(286, 118);
            this.currencyCb.Name = "currencyCb";
            this.currencyCb.Size = new System.Drawing.Size(70, 30);
            this.currencyCb.TabIndex = 113;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 22);
            this.label14.TabIndex = 112;
            this.label14.Text = "Cost Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 107;
            this.label9.Text = "Expiry at:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(362, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 22);
            this.label10.TabIndex = 106;
            this.label10.Text = "Production Date:";
            // 
            // barcodeTb
            // 
            this.barcodeTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTb.Location = new System.Drawing.Point(112, 82);
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(244, 30);
            this.barcodeTb.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 104;
            this.label7.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 101;
            this.label2.Text = "Description:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 30);
            this.menuStrip1.TabIndex = 118;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrencyToolStripMenuItem,
            this.addEditSupplierB,
            this.addEditProductB});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addCurrencyToolStripMenuItem
            // 
            this.addCurrencyToolStripMenuItem.Name = "addCurrencyToolStripMenuItem";
            this.addCurrencyToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.addCurrencyToolStripMenuItem.Text = "Add Currency";
            this.addCurrencyToolStripMenuItem.Click += new System.EventHandler(this.addCurrencyToolStripMenuItem_Click);
            // 
            // addEditSupplierB
            // 
            this.addEditSupplierB.Name = "addEditSupplierB";
            this.addEditSupplierB.Size = new System.Drawing.Size(210, 26);
            this.addEditSupplierB.Text = "Add Supplaier";
            this.addEditSupplierB.Click += new System.EventHandler(this.addEditSupplierB_Click);
            // 
            // addEditProductB
            // 
            this.addEditProductB.Name = "addEditProductB";
            this.addEditProductB.Size = new System.Drawing.Size(210, 26);
            this.addEditProductB.Text = "Add Product";
            this.addEditProductB.Click += new System.EventHandler(this.addEditProductB_Click);
            // 
            // AddEditBT
            // 
            this.AddEditBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEditBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddEditBT.Depth = 0;
            this.AddEditBT.HighEmphasis = true;
            this.AddEditBT.Icon = null;
            this.AddEditBT.Location = new System.Drawing.Point(581, 448);
            this.AddEditBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddEditBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddEditBT.Name = "AddEditBT";
            this.AddEditBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddEditBT.Size = new System.Drawing.Size(65, 36);
            this.AddEditBT.TabIndex = 119;
            this.AddEditBT.Text = "lable";
            this.AddEditBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddEditBT.UseAccentColor = false;
            this.AddEditBT.UseVisualStyleBackColor = true;
            this.AddEditBT.Click += new System.EventHandler(this.AddEditBT_Click);
            // 
            // productCb
            // 
            this.productCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCb.FormattingEnabled = true;
            this.productCb.Location = new System.Drawing.Point(112, 10);
            this.productCb.Name = "productCb";
            this.productCb.Size = new System.Drawing.Size(244, 30);
            this.productCb.TabIndex = 122;
            // 
            // supplaierCb
            // 
            this.supplaierCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplaierCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.supplaierCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplaierCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplaierCb.FormattingEnabled = true;
            this.supplaierCb.Location = new System.Drawing.Point(112, 46);
            this.supplaierCb.Name = "supplaierCb";
            this.supplaierCb.Size = new System.Drawing.Size(244, 30);
            this.supplaierCb.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 125;
            this.label5.Text = "Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 124;
            this.label6.Text = "Supplier:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddProduct);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(3, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 342);
            this.tabControl1.TabIndex = 130;
            // 
            // AddProduct
            // 
            this.AddProduct.Controls.Add(this.label8);
            this.AddProduct.Controls.Add(this.AvailableCb);
            this.AddProduct.Controls.Add(this.DescriptionTb);
            this.AddProduct.Controls.Add(this.quantTb);
            this.AddProduct.Controls.Add(this.label1);
            this.AddProduct.Controls.Add(this.ExpiryDate);
            this.AddProduct.Controls.Add(this.ProductionDate);
            this.AddProduct.Controls.Add(this.label2);
            this.AddProduct.Controls.Add(this.label7);
            this.AddProduct.Controls.Add(this.label5);
            this.AddProduct.Controls.Add(this.barcodeTb);
            this.AddProduct.Controls.Add(this.label6);
            this.AddProduct.Controls.Add(this.label10);
            this.AddProduct.Controls.Add(this.supplaierCb);
            this.AddProduct.Controls.Add(this.label9);
            this.AddProduct.Controls.Add(this.productCb);
            this.AddProduct.Controls.Add(this.label14);
            this.AddProduct.Controls.Add(this.currencyCb);
            this.AddProduct.Controls.Add(this.costPriceTb);
            this.AddProduct.Location = new System.Drawing.Point(4, 31);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.AddProduct.Size = new System.Drawing.Size(639, 307);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 137;
            this.label8.Text = "Available:";
            // 
            // AvailableCb
            // 
            this.AvailableCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AvailableCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AvailableCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableCb.FormattingEnabled = true;
            this.AvailableCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AvailableCb.Location = new System.Drawing.Point(478, 157);
            this.AvailableCb.Name = "AvailableCb";
            this.AvailableCb.Size = new System.Drawing.Size(138, 30);
            this.AvailableCb.TabIndex = 136;
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(132, 191);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(484, 98);
            this.DescriptionTb.TabIndex = 135;
            this.DescriptionTb.Text = "";
            // 
            // quantTb
            // 
            this.quantTb.DecimalPlaces = 3;
            this.quantTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.quantTb.Location = new System.Drawing.Point(133, 155);
            this.quantTb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.quantTb.Name = "quantTb";
            this.quantTb.Size = new System.Drawing.Size(147, 30);
            this.quantTb.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 132;
            this.label1.Text = "Quantity:";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.Location = new System.Drawing.Point(366, 121);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(250, 30);
            this.ExpiryDate.TabIndex = 131;
            // 
            // ProductionDate
            // 
            this.ProductionDate.Location = new System.Drawing.Point(366, 46);
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.Size = new System.Drawing.Size(250, 30);
            this.ProductionDate.TabIndex = 130;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ColumnCb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.RowCb);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SectionCb);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.WerehouseCb);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Location";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(327, 21);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(306, 280);
            this.treeView1.TabIndex = 140;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 139;
            this.label12.Text = "Column:";
            // 
            // ColumnCb
            // 
            this.ColumnCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColumnCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ColumnCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnCb.FormattingEnabled = true;
            this.ColumnCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ColumnCb.Location = new System.Drawing.Point(122, 129);
            this.ColumnCb.Name = "ColumnCb";
            this.ColumnCb.Size = new System.Drawing.Size(199, 30);
            this.ColumnCb.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 137;
            this.label4.Text = "Row:";
            // 
            // RowCb
            // 
            this.RowCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RowCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RowCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RowCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowCb.FormattingEnabled = true;
            this.RowCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.RowCb.Location = new System.Drawing.Point(122, 93);
            this.RowCb.Name = "RowCb";
            this.RowCb.Size = new System.Drawing.Size(199, 30);
            this.RowCb.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 135;
            this.label3.Text = "Section:";
            // 
            // SectionCb
            // 
            this.SectionCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SectionCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SectionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectionCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionCb.FormattingEnabled = true;
            this.SectionCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.SectionCb.Location = new System.Drawing.Point(122, 57);
            this.SectionCb.Name = "SectionCb";
            this.SectionCb.Size = new System.Drawing.Size(199, 30);
            this.SectionCb.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 22);
            this.label11.TabIndex = 133;
            this.label11.Text = "Werehouse:";
            // 
            // WerehouseCb
            // 
            this.WerehouseCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.WerehouseCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.WerehouseCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WerehouseCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WerehouseCb.FormattingEnabled = true;
            this.WerehouseCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.WerehouseCb.Location = new System.Drawing.Point(122, 21);
            this.WerehouseCb.Name = "WerehouseCb";
            this.WerehouseCb.Size = new System.Drawing.Size(199, 30);
            this.WerehouseCb.TabIndex = 132;
            // 
            // AddEditWerehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AddEditBT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddEditWerehouse";
            this.Text = "AddEditProducts";
            ((System.ComponentModel.ISupportInitialize)(this.costPriceTb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AddProduct.ResumeLayout(false);
            this.AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantTb)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown costPriceTb;
        private System.Windows.Forms.ComboBox currencyCb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox barcodeTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCurrencyToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton AddEditBT;
        private System.Windows.Forms.ToolStripMenuItem addEditSupplierB;
        private System.Windows.Forms.ToolStripMenuItem addEditProductB;
        private System.Windows.Forms.ComboBox productCb;
        private System.Windows.Forms.ComboBox supplaierCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AvailableCb;
        private System.Windows.Forms.RichTextBox DescriptionTb;
        private System.Windows.Forms.NumericUpDown quantTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ExpiryDate;
        private System.Windows.Forms.DateTimePicker ProductionDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ColumnCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RowCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SectionCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox WerehouseCb;
    }
}