
namespace Market
{
    partial class AddEditSup
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
            this.NextEnd = new MaterialSkin.Controls.MaterialButton();
            this.CancelBack = new MaterialSkin.Controls.MaterialButton();
            this.TapsPage = new System.Windows.Forms.TabControl();
            this.GenralTP = new System.Windows.Forms.TabPage();
            this.GDiscRTB = new System.Windows.Forms.RichTextBox();
            this.GVatTB = new System.Windows.Forms.TextBox();
            this.GNameArTB = new System.Windows.Forms.TextBox();
            this.GNameEnTB = new System.Windows.Forms.TextBox();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.EmailTP = new System.Windows.Forms.TabPage();
            this.SelectAllEmailsCb = new System.Windows.Forms.CheckBox();
            this.EmailsCBL = new System.Windows.Forms.CheckedListBox();
            this.EditEmailB = new System.Windows.Forms.Button();
            this.DeleteEmailB = new System.Windows.Forms.Button();
            this.AddEmailB = new System.Windows.Forms.Button();
            this.ContactTP = new System.Windows.Forms.TabPage();
            this.CallCheckAllCb = new System.Windows.Forms.CheckBox();
            this.ContactDGV = new System.Windows.Forms.DataGridView();
            this.EditContactB = new System.Windows.Forms.Button();
            this.DeleteContactB = new System.Windows.Forms.Button();
            this.AddContactB = new System.Windows.Forms.Button();
            this.BankTP = new System.Windows.Forms.TabPage();
            this.BnCheckAllCb = new System.Windows.Forms.CheckBox();
            this.BankDGV = new System.Windows.Forms.DataGridView();
            this.EditBankB = new System.Windows.Forms.Button();
            this.DeleteBankB = new System.Windows.Forms.Button();
            this.AddBankB = new System.Windows.Forms.Button();
            this.BnCbGv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BnIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BnFullNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BnIbanGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BnExpiryDateGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BnNameEnGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BnNameArGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallCbGv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CallIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallCountryGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTypeGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TapsPage.SuspendLayout();
            this.GenralTP.SuspendLayout();
            this.EmailTP.SuspendLayout();
            this.ContactTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDGV)).BeginInit();
            this.BankTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NextEnd
            // 
            this.NextEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextEnd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.NextEnd.Depth = 0;
            this.NextEnd.HighEmphasis = true;
            this.NextEnd.Icon = null;
            this.NextEnd.Location = new System.Drawing.Point(512, 405);
            this.NextEnd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NextEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.NextEnd.Name = "NextEnd";
            this.NextEnd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.NextEnd.Size = new System.Drawing.Size(64, 36);
            this.NextEnd.TabIndex = 0;
            this.NextEnd.Text = "Next";
            this.NextEnd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NextEnd.UseAccentColor = false;
            this.NextEnd.UseVisualStyleBackColor = true;
            this.NextEnd.Click += new System.EventHandler(this.NextEnd_Click);
            // 
            // CancelBack
            // 
            this.CancelBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelBack.Depth = 0;
            this.CancelBack.HighEmphasis = true;
            this.CancelBack.Icon = null;
            this.CancelBack.Location = new System.Drawing.Point(427, 405);
            this.CancelBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBack.Name = "CancelBack";
            this.CancelBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelBack.Size = new System.Drawing.Size(77, 36);
            this.CancelBack.TabIndex = 6;
            this.CancelBack.Text = "Cancel";
            this.CancelBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelBack.UseAccentColor = false;
            this.CancelBack.UseVisualStyleBackColor = true;
            // 
            // TapsPage
            // 
            this.TapsPage.Controls.Add(this.GenralTP);
            this.TapsPage.Controls.Add(this.EmailTP);
            this.TapsPage.Controls.Add(this.ContactTP);
            this.TapsPage.Controls.Add(this.BankTP);
            this.TapsPage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapsPage.Location = new System.Drawing.Point(7, 67);
            this.TapsPage.Name = "TapsPage";
            this.TapsPage.SelectedIndex = 0;
            this.TapsPage.Size = new System.Drawing.Size(573, 329);
            this.TapsPage.TabIndex = 18;
            this.TapsPage.SelectedIndexChanged += new System.EventHandler(this.TabsPage_SelectedIndexChanged);
            // 
            // GenralTP
            // 
            this.GenralTP.Controls.Add(this.GDiscRTB);
            this.GenralTP.Controls.Add(this.GVatTB);
            this.GenralTP.Controls.Add(this.GNameArTB);
            this.GenralTP.Controls.Add(this.GNameEnTB);
            this.GenralTP.Controls.Add(this.label_4);
            this.GenralTP.Controls.Add(this.label_3);
            this.GenralTP.Controls.Add(this.label_2);
            this.GenralTP.Controls.Add(this.label_1);
            this.GenralTP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenralTP.Location = new System.Drawing.Point(4, 28);
            this.GenralTP.Name = "GenralTP";
            this.GenralTP.Padding = new System.Windows.Forms.Padding(3);
            this.GenralTP.Size = new System.Drawing.Size(565, 297);
            this.GenralTP.TabIndex = 0;
            this.GenralTP.Text = "General";
            this.GenralTP.UseVisualStyleBackColor = true;
            // 
            // GDiscRTB
            // 
            this.GDiscRTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GDiscRTB.Location = new System.Drawing.Point(167, 137);
            this.GDiscRTB.Name = "GDiscRTB";
            this.GDiscRTB.Size = new System.Drawing.Size(346, 119);
            this.GDiscRTB.TabIndex = 26;
            this.GDiscRTB.Text = "";
            // 
            // GVatTB
            // 
            this.GVatTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GVatTB.Location = new System.Drawing.Point(167, 96);
            this.GVatTB.Name = "GVatTB";
            this.GVatTB.Size = new System.Drawing.Size(346, 32);
            this.GVatTB.TabIndex = 25;
            // 
            // GNameArTB
            // 
            this.GNameArTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GNameArTB.Location = new System.Drawing.Point(167, 58);
            this.GNameArTB.Name = "GNameArTB";
            this.GNameArTB.Size = new System.Drawing.Size(346, 32);
            this.GNameArTB.TabIndex = 23;
            // 
            // GNameEnTB
            // 
            this.GNameEnTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GNameEnTB.Location = new System.Drawing.Point(167, 20);
            this.GNameEnTB.Name = "GNameEnTB";
            this.GNameEnTB.Size = new System.Drawing.Size(346, 32);
            this.GNameEnTB.TabIndex = 22;
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_4.Location = new System.Drawing.Point(19, 137);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(142, 24);
            this.label_4.TabIndex = 21;
            this.label_4.Text = "Discrption:";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(19, 99);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(142, 24);
            this.label_3.TabIndex = 20;
            this.label_3.Text = "Vat Number:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(55, 61);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(106, 24);
            this.label_2.TabIndex = 19;
            this.label_2.Text = "Name Ar:";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(55, 23);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(106, 24);
            this.label_1.TabIndex = 18;
            this.label_1.Text = "Name En:";
            // 
            // EmailTP
            // 
            this.EmailTP.Controls.Add(this.SelectAllEmailsCb);
            this.EmailTP.Controls.Add(this.EmailsCBL);
            this.EmailTP.Controls.Add(this.EditEmailB);
            this.EmailTP.Controls.Add(this.DeleteEmailB);
            this.EmailTP.Controls.Add(this.AddEmailB);
            this.EmailTP.Location = new System.Drawing.Point(4, 28);
            this.EmailTP.Name = "EmailTP";
            this.EmailTP.Padding = new System.Windows.Forms.Padding(3);
            this.EmailTP.Size = new System.Drawing.Size(565, 297);
            this.EmailTP.TabIndex = 1;
            this.EmailTP.Text = "Emails";
            this.EmailTP.UseVisualStyleBackColor = true;
            // 
            // SelectAllEmailsCb
            // 
            this.SelectAllEmailsCb.AutoSize = true;
            this.SelectAllEmailsCb.Location = new System.Drawing.Point(6, 6);
            this.SelectAllEmailsCb.Name = "SelectAllEmailsCb";
            this.SelectAllEmailsCb.Size = new System.Drawing.Size(118, 23);
            this.SelectAllEmailsCb.TabIndex = 6;
            this.SelectAllEmailsCb.Text = "Select All";
            this.SelectAllEmailsCb.UseVisualStyleBackColor = true;
            this.SelectAllEmailsCb.CheckedChanged += new System.EventHandler(this.SelectAllEmailsCb_CheckedChanged);
            // 
            // EmailsCBL
            // 
            this.EmailsCBL.FormattingEnabled = true;
            this.EmailsCBL.Location = new System.Drawing.Point(6, 35);
            this.EmailsCBL.Name = "EmailsCBL";
            this.EmailsCBL.Size = new System.Drawing.Size(553, 193);
            this.EmailsCBL.TabIndex = 5;
            // 
            // EditEmailB
            // 
            this.EditEmailB.Location = new System.Drawing.Point(439, 256);
            this.EditEmailB.Name = "EditEmailB";
            this.EditEmailB.Size = new System.Drawing.Size(61, 35);
            this.EditEmailB.TabIndex = 4;
            this.EditEmailB.Text = "Edit";
            this.EditEmailB.UseVisualStyleBackColor = true;
            this.EditEmailB.Click += new System.EventHandler(this.EditEmailB_Click);
            // 
            // DeleteEmailB
            // 
            this.DeleteEmailB.Location = new System.Drawing.Point(350, 256);
            this.DeleteEmailB.Name = "DeleteEmailB";
            this.DeleteEmailB.Size = new System.Drawing.Size(83, 35);
            this.DeleteEmailB.TabIndex = 3;
            this.DeleteEmailB.Text = "Delete";
            this.DeleteEmailB.UseVisualStyleBackColor = true;
            this.DeleteEmailB.Click += new System.EventHandler(this.DeleteEmailB_Click);
            // 
            // AddEmailB
            // 
            this.AddEmailB.Location = new System.Drawing.Point(506, 256);
            this.AddEmailB.Name = "AddEmailB";
            this.AddEmailB.Size = new System.Drawing.Size(53, 35);
            this.AddEmailB.TabIndex = 2;
            this.AddEmailB.Text = "Add";
            this.AddEmailB.UseVisualStyleBackColor = true;
            this.AddEmailB.Click += new System.EventHandler(this.AddEmailB_Click);
            // 
            // ContactTP
            // 
            this.ContactTP.Controls.Add(this.CallCheckAllCb);
            this.ContactTP.Controls.Add(this.ContactDGV);
            this.ContactTP.Controls.Add(this.EditContactB);
            this.ContactTP.Controls.Add(this.DeleteContactB);
            this.ContactTP.Controls.Add(this.AddContactB);
            this.ContactTP.Location = new System.Drawing.Point(4, 28);
            this.ContactTP.Name = "ContactTP";
            this.ContactTP.Padding = new System.Windows.Forms.Padding(3);
            this.ContactTP.Size = new System.Drawing.Size(565, 297);
            this.ContactTP.TabIndex = 3;
            this.ContactTP.Text = "Contact";
            this.ContactTP.UseVisualStyleBackColor = true;
            // 
            // CallCheckAllCb
            // 
            this.CallCheckAllCb.AutoSize = true;
            this.CallCheckAllCb.Location = new System.Drawing.Point(50, 16);
            this.CallCheckAllCb.Name = "CallCheckAllCb";
            this.CallCheckAllCb.Size = new System.Drawing.Size(15, 14);
            this.CallCheckAllCb.TabIndex = 16;
            this.CallCheckAllCb.UseVisualStyleBackColor = true;
            // 
            // ContactDGV
            // 
            this.ContactDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CallCbGv,
            this.CallIdGv,
            this.contactNoGv,
            this.CallCountryGv,
            this.ContactTypeGv});
            this.ContactDGV.Location = new System.Drawing.Point(6, 6);
            this.ContactDGV.Name = "ContactDGV";
            this.ContactDGV.Size = new System.Drawing.Size(553, 244);
            this.ContactDGV.TabIndex = 13;
            // 
            // EditContactB
            // 
            this.EditContactB.Location = new System.Drawing.Point(439, 256);
            this.EditContactB.Name = "EditContactB";
            this.EditContactB.Size = new System.Drawing.Size(61, 35);
            this.EditContactB.TabIndex = 7;
            this.EditContactB.Text = "Edit";
            this.EditContactB.UseVisualStyleBackColor = true;
            // 
            // DeleteContactB
            // 
            this.DeleteContactB.Location = new System.Drawing.Point(350, 256);
            this.DeleteContactB.Name = "DeleteContactB";
            this.DeleteContactB.Size = new System.Drawing.Size(83, 35);
            this.DeleteContactB.TabIndex = 6;
            this.DeleteContactB.Text = "Delete";
            this.DeleteContactB.UseVisualStyleBackColor = true;
            // 
            // AddContactB
            // 
            this.AddContactB.Location = new System.Drawing.Point(506, 256);
            this.AddContactB.Name = "AddContactB";
            this.AddContactB.Size = new System.Drawing.Size(53, 35);
            this.AddContactB.TabIndex = 5;
            this.AddContactB.Text = "Add";
            this.AddContactB.UseVisualStyleBackColor = true;
            // 
            // BankTP
            // 
            this.BankTP.Controls.Add(this.BnCheckAllCb);
            this.BankTP.Controls.Add(this.BankDGV);
            this.BankTP.Controls.Add(this.EditBankB);
            this.BankTP.Controls.Add(this.DeleteBankB);
            this.BankTP.Controls.Add(this.AddBankB);
            this.BankTP.Location = new System.Drawing.Point(4, 28);
            this.BankTP.Name = "BankTP";
            this.BankTP.Padding = new System.Windows.Forms.Padding(3);
            this.BankTP.Size = new System.Drawing.Size(565, 297);
            this.BankTP.TabIndex = 4;
            this.BankTP.Text = "Bank Accounts";
            this.BankTP.UseVisualStyleBackColor = true;
            // 
            // BnCheckAllCb
            // 
            this.BnCheckAllCb.AutoSize = true;
            this.BnCheckAllCb.Location = new System.Drawing.Point(51, 15);
            this.BnCheckAllCb.Name = "BnCheckAllCb";
            this.BnCheckAllCb.Size = new System.Drawing.Size(15, 14);
            this.BnCheckAllCb.TabIndex = 15;
            this.BnCheckAllCb.UseVisualStyleBackColor = true;
            // 
            // BankDGV
            // 
            this.BankDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BnCbGv,
            this.BnIdGv,
            this.BnFullNameGv,
            this.BnIbanGv,
            this.BnExpiryDateGv,
            this.BnNameEnGv,
            this.BnNameArGv});
            this.BankDGV.Location = new System.Drawing.Point(6, 6);
            this.BankDGV.Name = "BankDGV";
            this.BankDGV.Size = new System.Drawing.Size(553, 244);
            this.BankDGV.TabIndex = 14;
            // 
            // EditBankB
            // 
            this.EditBankB.Location = new System.Drawing.Point(439, 256);
            this.EditBankB.Name = "EditBankB";
            this.EditBankB.Size = new System.Drawing.Size(61, 35);
            this.EditBankB.TabIndex = 11;
            this.EditBankB.Text = "Edit";
            this.EditBankB.UseVisualStyleBackColor = true;
            // 
            // DeleteBankB
            // 
            this.DeleteBankB.Location = new System.Drawing.Point(350, 256);
            this.DeleteBankB.Name = "DeleteBankB";
            this.DeleteBankB.Size = new System.Drawing.Size(83, 35);
            this.DeleteBankB.TabIndex = 10;
            this.DeleteBankB.Text = "Delete";
            this.DeleteBankB.UseVisualStyleBackColor = true;
            // 
            // AddBankB
            // 
            this.AddBankB.Location = new System.Drawing.Point(506, 256);
            this.AddBankB.Name = "AddBankB";
            this.AddBankB.Size = new System.Drawing.Size(53, 35);
            this.AddBankB.TabIndex = 9;
            this.AddBankB.Text = "Add";
            this.AddBankB.UseVisualStyleBackColor = true;
            // 
            // BnCbGv
            // 
            this.BnCbGv.Frozen = true;
            this.BnCbGv.HeaderText = "";
            this.BnCbGv.Name = "BnCbGv";
            this.BnCbGv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BnCbGv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BnCbGv.Width = 20;
            // 
            // BnIdGv
            // 
            this.BnIdGv.DataPropertyName = "ID";
            this.BnIdGv.HeaderText = "ID";
            this.BnIdGv.Name = "BnIdGv";
            this.BnIdGv.ReadOnly = true;
            this.BnIdGv.Width = 50;
            // 
            // BnFullNameGv
            // 
            this.BnFullNameGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BnFullNameGv.DataPropertyName = "noneFullNameOwner";
            this.BnFullNameGv.HeaderText = "Full Name";
            this.BnFullNameGv.Name = "BnFullNameGv";
            this.BnFullNameGv.ReadOnly = true;
            this.BnFullNameGv.Width = 150;
            // 
            // BnIbanGv
            // 
            this.BnIbanGv.DataPropertyName = "Iban";
            this.BnIbanGv.HeaderText = "Iban";
            this.BnIbanGv.Name = "BnIbanGv";
            this.BnIbanGv.ReadOnly = true;
            this.BnIbanGv.Width = 200;
            // 
            // BnExpiryDateGv
            // 
            this.BnExpiryDateGv.DataPropertyName = "ExpiryDate";
            this.BnExpiryDateGv.HeaderText = "Expiry Date";
            this.BnExpiryDateGv.Name = "BnExpiryDateGv";
            this.BnExpiryDateGv.ReadOnly = true;
            this.BnExpiryDateGv.Width = 140;
            // 
            // BnNameEnGv
            // 
            this.BnNameEnGv.DataPropertyName = "NameEn";
            this.BnNameEnGv.HeaderText = "Bank Name En";
            this.BnNameEnGv.Name = "BnNameEnGv";
            this.BnNameEnGv.ReadOnly = true;
            this.BnNameEnGv.Width = 150;
            // 
            // BnNameArGv
            // 
            this.BnNameArGv.DataPropertyName = "NameAr";
            this.BnNameArGv.HeaderText = "Bank Name Ar";
            this.BnNameArGv.Name = "BnNameArGv";
            this.BnNameArGv.ReadOnly = true;
            this.BnNameArGv.Width = 150;
            // 
            // CallCbGv
            // 
            this.CallCbGv.Frozen = true;
            this.CallCbGv.HeaderText = "";
            this.CallCbGv.Name = "CallCbGv";
            this.CallCbGv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CallCbGv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CallCbGv.Width = 20;
            // 
            // CallIdGv
            // 
            this.CallIdGv.DataPropertyName = "ID";
            this.CallIdGv.HeaderText = "ID";
            this.CallIdGv.Name = "CallIdGv";
            this.CallIdGv.ReadOnly = true;
            this.CallIdGv.Width = 50;
            // 
            // contactNoGv
            // 
            this.contactNoGv.DataPropertyName = "ContactNumber";
            this.contactNoGv.HeaderText = "Contact Number";
            this.contactNoGv.Name = "contactNoGv";
            this.contactNoGv.ReadOnly = true;
            this.contactNoGv.Width = 190;
            // 
            // CallCountryGv
            // 
            this.CallCountryGv.DataPropertyName = "Shortcut";
            this.CallCountryGv.HeaderText = "Country";
            this.CallCountryGv.Name = "CallCountryGv";
            this.CallCountryGv.ReadOnly = true;
            // 
            // ContactTypeGv
            // 
            this.ContactTypeGv.DataPropertyName = "ContactType";
            this.ContactTypeGv.HeaderText = "Contact Type";
            this.ContactTypeGv.Name = "ContactTypeGv";
            this.ContactTypeGv.ReadOnly = true;
            this.ContactTypeGv.Width = 150;
            // 
            // AddEditSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.TapsPage);
            this.Controls.Add(this.CancelBack);
            this.Controls.Add(this.NextEnd);
            this.Name = "AddEditSup";
            this.Text = "Add New User";
            this.TapsPage.ResumeLayout(false);
            this.GenralTP.ResumeLayout(false);
            this.GenralTP.PerformLayout();
            this.EmailTP.ResumeLayout(false);
            this.EmailTP.PerformLayout();
            this.ContactTP.ResumeLayout(false);
            this.ContactTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDGV)).EndInit();
            this.BankTP.ResumeLayout(false);
            this.BankTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton NextEnd;
        private MaterialSkin.Controls.MaterialButton CancelBack;
        private System.Windows.Forms.TabControl TapsPage;
        private System.Windows.Forms.TabPage GenralTP;
        private System.Windows.Forms.RichTextBox GDiscRTB;
        private System.Windows.Forms.TextBox GVatTB;
        private System.Windows.Forms.TextBox GNameArTB;
        private System.Windows.Forms.TextBox GNameEnTB;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TabPage EmailTP;
        private System.Windows.Forms.TabPage ContactTP;
        private System.Windows.Forms.Button EditEmailB;
        private System.Windows.Forms.Button DeleteEmailB;
        private System.Windows.Forms.Button AddEmailB;
        private System.Windows.Forms.Button EditContactB;
        private System.Windows.Forms.Button DeleteContactB;
        private System.Windows.Forms.Button AddContactB;
        private System.Windows.Forms.TabPage BankTP;
        private System.Windows.Forms.Button EditBankB;
        private System.Windows.Forms.Button DeleteBankB;
        private System.Windows.Forms.Button AddBankB;
        private System.Windows.Forms.DataGridView ContactDGV;
        private System.Windows.Forms.DataGridView BankDGV;
        private System.Windows.Forms.CheckBox CallCheckAllCb;
        private System.Windows.Forms.CheckBox BnCheckAllCb;
        private System.Windows.Forms.CheckBox SelectAllEmailsCb;
        private System.Windows.Forms.CheckedListBox EmailsCBL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BnCbGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BnIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BnFullNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BnIbanGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BnExpiryDateGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BnNameEnGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BnNameArGv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CallCbGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallCountryGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTypeGv;
    }
}