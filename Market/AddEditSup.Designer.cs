
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
            this.EditEmailB = new System.Windows.Forms.Button();
            this.DeleteEmailB = new System.Windows.Forms.Button();
            this.AddEmailB = new System.Windows.Forms.Button();
            this.EmailsCBL = new System.Windows.Forms.CheckedListBox();
            this.AddressTP = new System.Windows.Forms.TabPage();
            this.EditAddressB = new System.Windows.Forms.Button();
            this.DeleteAddressB = new System.Windows.Forms.Button();
            this.AddAddressB = new System.Windows.Forms.Button();
            this.AddressesCBL = new System.Windows.Forms.CheckedListBox();
            this.ContactTP = new System.Windows.Forms.TabPage();
            this.EditContactB = new System.Windows.Forms.Button();
            this.DeleteContactB = new System.Windows.Forms.Button();
            this.AddContactB = new System.Windows.Forms.Button();
            this.ContactsCBL = new System.Windows.Forms.CheckedListBox();
            this.BankTP = new System.Windows.Forms.TabPage();
            this.EditBankB = new System.Windows.Forms.Button();
            this.DeleteBankB = new System.Windows.Forms.Button();
            this.AddBankB = new System.Windows.Forms.Button();
            this.BanksCBL = new System.Windows.Forms.CheckedListBox();
            this.TapsPage.SuspendLayout();
            this.GenralTP.SuspendLayout();
            this.EmailTP.SuspendLayout();
            this.AddressTP.SuspendLayout();
            this.ContactTP.SuspendLayout();
            this.BankTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextEnd
            // 
            this.NextEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextEnd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.NextEnd.Depth = 0;
            this.NextEnd.HighEmphasis = true;
            this.NextEnd.Icon = null;
            this.NextEnd.Location = new System.Drawing.Point(420, 405);
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
            this.CancelBack.Location = new System.Drawing.Point(335, 405);
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
            this.TapsPage.Controls.Add(this.AddressTP);
            this.TapsPage.Controls.Add(this.ContactTP);
            this.TapsPage.Controls.Add(this.BankTP);
            this.TapsPage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapsPage.Location = new System.Drawing.Point(7, 67);
            this.TapsPage.Name = "TapsPage";
            this.TapsPage.SelectedIndex = 0;
            this.TapsPage.Size = new System.Drawing.Size(478, 329);
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
            this.GenralTP.Size = new System.Drawing.Size(470, 297);
            this.GenralTP.TabIndex = 0;
            this.GenralTP.Text = "General";
            this.GenralTP.UseVisualStyleBackColor = true;
            // 
            // GDiscRTB
            // 
            this.GDiscRTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GDiscRTB.Location = new System.Drawing.Point(167, 137);
            this.GDiscRTB.Name = "GDiscRTB";
            this.GDiscRTB.Size = new System.Drawing.Size(285, 113);
            this.GDiscRTB.TabIndex = 26;
            this.GDiscRTB.Text = "";
            // 
            // GVatTB
            // 
            this.GVatTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GVatTB.Location = new System.Drawing.Point(167, 96);
            this.GVatTB.Name = "GVatTB";
            this.GVatTB.Size = new System.Drawing.Size(285, 32);
            this.GVatTB.TabIndex = 25;
            // 
            // GNameArTB
            // 
            this.GNameArTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GNameArTB.Location = new System.Drawing.Point(167, 58);
            this.GNameArTB.Name = "GNameArTB";
            this.GNameArTB.Size = new System.Drawing.Size(285, 32);
            this.GNameArTB.TabIndex = 23;
            // 
            // GNameEnTB
            // 
            this.GNameEnTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.GNameEnTB.Location = new System.Drawing.Point(167, 20);
            this.GNameEnTB.Name = "GNameEnTB";
            this.GNameEnTB.Size = new System.Drawing.Size(285, 32);
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
            this.EmailTP.Controls.Add(this.EditEmailB);
            this.EmailTP.Controls.Add(this.DeleteEmailB);
            this.EmailTP.Controls.Add(this.AddEmailB);
            this.EmailTP.Controls.Add(this.EmailsCBL);
            this.EmailTP.Location = new System.Drawing.Point(4, 28);
            this.EmailTP.Name = "EmailTP";
            this.EmailTP.Padding = new System.Windows.Forms.Padding(3);
            this.EmailTP.Size = new System.Drawing.Size(470, 297);
            this.EmailTP.TabIndex = 1;
            this.EmailTP.Text = "Emails";
            this.EmailTP.UseVisualStyleBackColor = true;
            // 
            // EditEmailB
            // 
            this.EditEmailB.Location = new System.Drawing.Point(343, 256);
            this.EditEmailB.Name = "EditEmailB";
            this.EditEmailB.Size = new System.Drawing.Size(61, 35);
            this.EditEmailB.TabIndex = 4;
            this.EditEmailB.Text = "Edit";
            this.EditEmailB.UseVisualStyleBackColor = true;
            this.EditEmailB.Click += new System.EventHandler(this.EditEmailB_Click);
            // 
            // DeleteEmailB
            // 
            this.DeleteEmailB.Location = new System.Drawing.Point(254, 256);
            this.DeleteEmailB.Name = "DeleteEmailB";
            this.DeleteEmailB.Size = new System.Drawing.Size(83, 35);
            this.DeleteEmailB.TabIndex = 3;
            this.DeleteEmailB.Text = "Delete";
            this.DeleteEmailB.UseVisualStyleBackColor = true;
            // 
            // AddEmailB
            // 
            this.AddEmailB.Location = new System.Drawing.Point(410, 256);
            this.AddEmailB.Name = "AddEmailB";
            this.AddEmailB.Size = new System.Drawing.Size(53, 35);
            this.AddEmailB.TabIndex = 2;
            this.AddEmailB.Text = "Add";
            this.AddEmailB.UseVisualStyleBackColor = true;
            // 
            // EmailsCBL
            // 
            this.EmailsCBL.FormattingEnabled = true;
            this.EmailsCBL.Location = new System.Drawing.Point(6, 6);
            this.EmailsCBL.Name = "EmailsCBL";
            this.EmailsCBL.Size = new System.Drawing.Size(458, 193);
            this.EmailsCBL.TabIndex = 1;
            // 
            // AddressTP
            // 
            this.AddressTP.Controls.Add(this.EditAddressB);
            this.AddressTP.Controls.Add(this.DeleteAddressB);
            this.AddressTP.Controls.Add(this.AddAddressB);
            this.AddressTP.Controls.Add(this.AddressesCBL);
            this.AddressTP.Location = new System.Drawing.Point(4, 28);
            this.AddressTP.Name = "AddressTP";
            this.AddressTP.Padding = new System.Windows.Forms.Padding(3);
            this.AddressTP.Size = new System.Drawing.Size(470, 297);
            this.AddressTP.TabIndex = 2;
            this.AddressTP.Text = "Address";
            this.AddressTP.UseVisualStyleBackColor = true;
            // 
            // EditAddressB
            // 
            this.EditAddressB.Location = new System.Drawing.Point(343, 256);
            this.EditAddressB.Name = "EditAddressB";
            this.EditAddressB.Size = new System.Drawing.Size(61, 35);
            this.EditAddressB.TabIndex = 11;
            this.EditAddressB.Text = "Edit";
            this.EditAddressB.UseVisualStyleBackColor = true;
            // 
            // DeleteAddressB
            // 
            this.DeleteAddressB.Location = new System.Drawing.Point(254, 256);
            this.DeleteAddressB.Name = "DeleteAddressB";
            this.DeleteAddressB.Size = new System.Drawing.Size(83, 35);
            this.DeleteAddressB.TabIndex = 10;
            this.DeleteAddressB.Text = "Delete";
            this.DeleteAddressB.UseVisualStyleBackColor = true;
            // 
            // AddAddressB
            // 
            this.AddAddressB.Location = new System.Drawing.Point(410, 256);
            this.AddAddressB.Name = "AddAddressB";
            this.AddAddressB.Size = new System.Drawing.Size(53, 35);
            this.AddAddressB.TabIndex = 9;
            this.AddAddressB.Text = "Add";
            this.AddAddressB.UseVisualStyleBackColor = true;
            // 
            // AddressesCBL
            // 
            this.AddressesCBL.FormattingEnabled = true;
            this.AddressesCBL.Location = new System.Drawing.Point(6, 6);
            this.AddressesCBL.Name = "AddressesCBL";
            this.AddressesCBL.Size = new System.Drawing.Size(458, 193);
            this.AddressesCBL.TabIndex = 8;
            // 
            // ContactTP
            // 
            this.ContactTP.Controls.Add(this.EditContactB);
            this.ContactTP.Controls.Add(this.DeleteContactB);
            this.ContactTP.Controls.Add(this.AddContactB);
            this.ContactTP.Controls.Add(this.ContactsCBL);
            this.ContactTP.Location = new System.Drawing.Point(4, 28);
            this.ContactTP.Name = "ContactTP";
            this.ContactTP.Padding = new System.Windows.Forms.Padding(3);
            this.ContactTP.Size = new System.Drawing.Size(470, 297);
            this.ContactTP.TabIndex = 3;
            this.ContactTP.Text = "Contact";
            this.ContactTP.UseVisualStyleBackColor = true;
            // 
            // EditContactB
            // 
            this.EditContactB.Location = new System.Drawing.Point(343, 256);
            this.EditContactB.Name = "EditContactB";
            this.EditContactB.Size = new System.Drawing.Size(61, 35);
            this.EditContactB.TabIndex = 7;
            this.EditContactB.Text = "Edit";
            this.EditContactB.UseVisualStyleBackColor = true;
            // 
            // DeleteContactB
            // 
            this.DeleteContactB.Location = new System.Drawing.Point(254, 256);
            this.DeleteContactB.Name = "DeleteContactB";
            this.DeleteContactB.Size = new System.Drawing.Size(83, 35);
            this.DeleteContactB.TabIndex = 6;
            this.DeleteContactB.Text = "Delete";
            this.DeleteContactB.UseVisualStyleBackColor = true;
            // 
            // AddContactB
            // 
            this.AddContactB.Location = new System.Drawing.Point(410, 256);
            this.AddContactB.Name = "AddContactB";
            this.AddContactB.Size = new System.Drawing.Size(53, 35);
            this.AddContactB.TabIndex = 5;
            this.AddContactB.Text = "Add";
            this.AddContactB.UseVisualStyleBackColor = true;
            // 
            // ContactsCBL
            // 
            this.ContactsCBL.FormattingEnabled = true;
            this.ContactsCBL.Location = new System.Drawing.Point(6, 6);
            this.ContactsCBL.Name = "ContactsCBL";
            this.ContactsCBL.Size = new System.Drawing.Size(458, 193);
            this.ContactsCBL.TabIndex = 4;
            // 
            // BankTP
            // 
            this.BankTP.Controls.Add(this.EditBankB);
            this.BankTP.Controls.Add(this.DeleteBankB);
            this.BankTP.Controls.Add(this.AddBankB);
            this.BankTP.Controls.Add(this.BanksCBL);
            this.BankTP.Location = new System.Drawing.Point(4, 28);
            this.BankTP.Name = "BankTP";
            this.BankTP.Padding = new System.Windows.Forms.Padding(3);
            this.BankTP.Size = new System.Drawing.Size(470, 297);
            this.BankTP.TabIndex = 4;
            this.BankTP.Text = "Bank Accounts";
            this.BankTP.UseVisualStyleBackColor = true;
            // 
            // EditBankB
            // 
            this.EditBankB.Location = new System.Drawing.Point(343, 256);
            this.EditBankB.Name = "EditBankB";
            this.EditBankB.Size = new System.Drawing.Size(61, 35);
            this.EditBankB.TabIndex = 11;
            this.EditBankB.Text = "Edit";
            this.EditBankB.UseVisualStyleBackColor = true;
            // 
            // DeleteBankB
            // 
            this.DeleteBankB.Location = new System.Drawing.Point(254, 256);
            this.DeleteBankB.Name = "DeleteBankB";
            this.DeleteBankB.Size = new System.Drawing.Size(83, 35);
            this.DeleteBankB.TabIndex = 10;
            this.DeleteBankB.Text = "Delete";
            this.DeleteBankB.UseVisualStyleBackColor = true;
            // 
            // AddBankB
            // 
            this.AddBankB.Location = new System.Drawing.Point(410, 256);
            this.AddBankB.Name = "AddBankB";
            this.AddBankB.Size = new System.Drawing.Size(53, 35);
            this.AddBankB.TabIndex = 9;
            this.AddBankB.Text = "Add";
            this.AddBankB.UseVisualStyleBackColor = true;
            // 
            // BanksCBL
            // 
            this.BanksCBL.FormattingEnabled = true;
            this.BanksCBL.Location = new System.Drawing.Point(6, 6);
            this.BanksCBL.Name = "BanksCBL";
            this.BanksCBL.Size = new System.Drawing.Size(458, 193);
            this.BanksCBL.TabIndex = 8;
            // 
            // AddEditSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.TapsPage);
            this.Controls.Add(this.CancelBack);
            this.Controls.Add(this.NextEnd);
            this.Name = "AddEditSup";
            this.Text = "Add New User";
            this.TapsPage.ResumeLayout(false);
            this.GenralTP.ResumeLayout(false);
            this.GenralTP.PerformLayout();
            this.EmailTP.ResumeLayout(false);
            this.AddressTP.ResumeLayout(false);
            this.ContactTP.ResumeLayout(false);
            this.BankTP.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage AddressTP;
        private System.Windows.Forms.TabPage ContactTP;
        private System.Windows.Forms.Button EditEmailB;
        private System.Windows.Forms.Button DeleteEmailB;
        private System.Windows.Forms.Button AddEmailB;
        private System.Windows.Forms.CheckedListBox EmailsCBL;
        private System.Windows.Forms.CheckedListBox AddressesCBL;
        private System.Windows.Forms.Button EditContactB;
        private System.Windows.Forms.Button DeleteContactB;
        private System.Windows.Forms.Button AddContactB;
        private System.Windows.Forms.CheckedListBox ContactsCBL;
        private System.Windows.Forms.Button EditAddressB;
        private System.Windows.Forms.Button DeleteAddressB;
        private System.Windows.Forms.Button AddAddressB;
        private System.Windows.Forms.TabPage BankTP;
        private System.Windows.Forms.Button EditBankB;
        private System.Windows.Forms.Button DeleteBankB;
        private System.Windows.Forms.Button AddBankB;
        private System.Windows.Forms.CheckedListBox BanksCBL;
    }
}