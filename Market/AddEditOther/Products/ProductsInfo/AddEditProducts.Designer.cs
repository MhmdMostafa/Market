
namespace Market.AddEditOther.Product
{
    partial class AddEditProducts
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
            this.sizeTb = new System.Windows.Forms.NumericUpDown();
            this.unitValueCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salePriceTb = new System.Windows.Forms.NumericUpDown();
            this.currencyCb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.skuTb = new System.Windows.Forms.TextBox();
            this.upcTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameArTb = new System.Windows.Forms.TextBox();
            this.nameEnTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEditBT = new MaterialSkin.Controls.MaterialButton();
            this.isbnTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groubCb = new System.Windows.Forms.ComboBox();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vatCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prescriptionCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salePriceTb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeTb
            // 
            this.sizeTb.DecimalPlaces = 3;
            this.sizeTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.sizeTb.Location = new System.Drawing.Point(133, 235);
            this.sizeTb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.sizeTb.Name = "sizeTb";
            this.sizeTb.Size = new System.Drawing.Size(139, 30);
            this.sizeTb.TabIndex = 117;
            this.sizeTb.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            // 
            // unitValueCb
            // 
            this.unitValueCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitValueCb.FormattingEnabled = true;
            this.unitValueCb.Location = new System.Drawing.Point(278, 235);
            this.unitValueCb.Name = "unitValueCb";
            this.unitValueCb.Size = new System.Drawing.Size(99, 30);
            this.unitValueCb.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 115;
            this.label3.Text = "Size:";
            // 
            // salePriceTb
            // 
            this.salePriceTb.DecimalPlaces = 3;
            this.salePriceTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.salePriceTb.Location = new System.Drawing.Point(133, 271);
            this.salePriceTb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.salePriceTb.Name = "salePriceTb";
            this.salePriceTb.Size = new System.Drawing.Size(139, 30);
            this.salePriceTb.TabIndex = 114;
            // 
            // currencyCb
            // 
            this.currencyCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyCb.FormattingEnabled = true;
            this.currencyCb.Location = new System.Drawing.Point(278, 271);
            this.currencyCb.Name = "currencyCb";
            this.currencyCb.Size = new System.Drawing.Size(99, 30);
            this.currencyCb.TabIndex = 113;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 22);
            this.label14.TabIndex = 112;
            this.label14.Text = "Sale Price:";
            // 
            // skuTb
            // 
            this.skuTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuTb.Location = new System.Drawing.Point(478, 127);
            this.skuTb.Name = "skuTb";
            this.skuTb.Size = new System.Drawing.Size(250, 30);
            this.skuTb.TabIndex = 109;
            // 
            // upcTb
            // 
            this.upcTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcTb.Location = new System.Drawing.Point(478, 91);
            this.upcTb.Name = "upcTb";
            this.upcTb.Size = new System.Drawing.Size(250, 30);
            this.upcTb.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(422, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 22);
            this.label9.TabIndex = 107;
            this.label9.Text = "SKU:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(422, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 22);
            this.label10.TabIndex = 106;
            this.label10.Text = "UPC:";
            // 
            // barcodeTb
            // 
            this.barcodeTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTb.Location = new System.Drawing.Point(478, 199);
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(250, 30);
            this.barcodeTb.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 104;
            this.label7.Text = "Barcode:";
            // 
            // nameArTb
            // 
            this.nameArTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameArTb.Location = new System.Drawing.Point(133, 127);
            this.nameArTb.Name = "nameArTb";
            this.nameArTb.Size = new System.Drawing.Size(243, 30);
            this.nameArTb.TabIndex = 103;
            // 
            // nameEnTb
            // 
            this.nameEnTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEnTb.Location = new System.Drawing.Point(132, 91);
            this.nameEnTb.Name = "nameEnTb";
            this.nameEnTb.Size = new System.Drawing.Size(244, 30);
            this.nameEnTb.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 101;
            this.label2.Text = "Name EN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 100;
            this.label1.Text = "Name AR:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 30);
            this.menuStrip1.TabIndex = 118;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitValueToolStripMenuItem,
            this.addCurrencyToolStripMenuItem,
            this.addGroupToolStripMenuItem,
            this.addTypeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addUnitValueToolStripMenuItem
            // 
            this.addUnitValueToolStripMenuItem.Name = "addUnitValueToolStripMenuItem";
            this.addUnitValueToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addUnitValueToolStripMenuItem.Text = "Add Unit Value";
            this.addUnitValueToolStripMenuItem.Click += new System.EventHandler(this.addUnitValueToolStripMenuItem_Click);
            // 
            // addCurrencyToolStripMenuItem
            // 
            this.addCurrencyToolStripMenuItem.Name = "addCurrencyToolStripMenuItem";
            this.addCurrencyToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addCurrencyToolStripMenuItem.Text = "Add Currency";
            this.addCurrencyToolStripMenuItem.Click += new System.EventHandler(this.addCurrencyToolStripMenuItem_Click);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addGroupToolStripMenuItem.Text = "Add Group";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.addGroupToolStripMenuItem_Click);
            // 
            // addTypeToolStripMenuItem
            // 
            this.addTypeToolStripMenuItem.Name = "addTypeToolStripMenuItem";
            this.addTypeToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addTypeToolStripMenuItem.Text = "Add Type";
            this.addTypeToolStripMenuItem.Click += new System.EventHandler(this.addTypeToolStripMenuItem_Click);
            // 
            // AddEditBT
            // 
            this.AddEditBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEditBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddEditBT.Depth = 0;
            this.AddEditBT.HighEmphasis = true;
            this.AddEditBT.Icon = null;
            this.AddEditBT.Location = new System.Drawing.Point(663, 310);
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
            // isbnTb
            // 
            this.isbnTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTb.Location = new System.Drawing.Point(478, 163);
            this.isbnTb.Name = "isbnTb";
            this.isbnTb.Size = new System.Drawing.Size(250, 30);
            this.isbnTb.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 120;
            this.label4.Text = "ISBN:";
            // 
            // groubCb
            // 
            this.groubCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groubCb.FormattingEnabled = true;
            this.groubCb.Location = new System.Drawing.Point(132, 163);
            this.groubCb.Name = "groubCb";
            this.groubCb.Size = new System.Drawing.Size(244, 30);
            this.groubCb.TabIndex = 122;
            // 
            // typeCb
            // 
            this.typeCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Location = new System.Drawing.Point(132, 199);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(244, 30);
            this.typeCb.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 125;
            this.label5.Text = "Group:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 124;
            this.label6.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 127;
            this.label8.Text = "Vat:";
            // 
            // vatCb
            // 
            this.vatCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatCb.FormattingEnabled = true;
            this.vatCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.vatCb.Location = new System.Drawing.Point(529, 271);
            this.vatCb.Name = "vatCb";
            this.vatCb.Size = new System.Drawing.Size(199, 30);
            this.vatCb.TabIndex = 126;
            this.vatCb.SelectedIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 22);
            this.label11.TabIndex = 129;
            this.label11.Text = "Prescription:";
            // 
            // prescriptionCb
            // 
            this.prescriptionCb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionCb.FormattingEnabled = true;
            this.prescriptionCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.prescriptionCb.Location = new System.Drawing.Point(529, 235);
            this.prescriptionCb.Name = "prescriptionCb";
            this.prescriptionCb.Size = new System.Drawing.Size(199, 30);
            this.prescriptionCb.TabIndex = 128;
            this.prescriptionCb.SelectedIndex = 1;
            // 
            // AddEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 358);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prescriptionCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vatCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.groubCb);
            this.Controls.Add(this.isbnTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddEditBT);
            this.Controls.Add(this.sizeTb);
            this.Controls.Add(this.unitValueCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salePriceTb);
            this.Controls.Add(this.currencyCb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.skuTb);
            this.Controls.Add(this.upcTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.barcodeTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameArTb);
            this.Controls.Add(this.nameEnTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddEditProducts";
            this.Text = "AddEditProducts";
            ((System.ComponentModel.ISupportInitialize)(this.sizeTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salePriceTb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sizeTb;
        private System.Windows.Forms.ComboBox unitValueCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown salePriceTb;
        private System.Windows.Forms.ComboBox currencyCb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox skuTb;
        private System.Windows.Forms.TextBox upcTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox barcodeTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameArTb;
        private System.Windows.Forms.TextBox nameEnTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCurrencyToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton AddEditBT;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTypeToolStripMenuItem;
        private System.Windows.Forms.TextBox isbnTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox groubCb;
        private System.Windows.Forms.ComboBox typeCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox vatCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox prescriptionCb;
    }
}