﻿
namespace Market
{
    partial class AddEditAddress
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
            this.applyB = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DistrictTB = new System.Windows.Forms.TextBox();
            this.NameEn = new System.Windows.Forms.Label();
            this.StreetTB = new System.Windows.Forms.TextBox();
            this.NameAr = new System.Windows.Forms.Label();
            this.ContryCB = new System.Windows.Forms.ComboBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.DiscRTB = new System.Windows.Forms.RichTextBox();
            this.ZipCodeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCountryB = new System.Windows.Forms.Button();
            this.AddCityB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applyB
            // 
            this.applyB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyB.Depth = 0;
            this.applyB.HighEmphasis = true;
            this.applyB.Icon = null;
            this.applyB.Location = new System.Drawing.Point(352, 383);
            this.applyB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyB.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyB.Name = "applyB";
            this.applyB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyB.Size = new System.Drawing.Size(65, 36);
            this.applyB.TabIndex = 46;
            this.applyB.Text = "apply";
            this.applyB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyB.UseAccentColor = false;
            this.applyB.UseVisualStyleBackColor = true;
            this.applyB.Click += new System.EventHandler(this.applyB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Description:";
            // 
            // DistrictTB
            // 
            this.DistrictTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.DistrictTB.Location = new System.Drawing.Point(134, 162);
            this.DistrictTB.Name = "DistrictTB";
            this.DistrictTB.Size = new System.Drawing.Size(285, 32);
            this.DistrictTB.TabIndex = 41;
            // 
            // NameEn
            // 
            this.NameEn.AllowDrop = true;
            this.NameEn.AutoSize = true;
            this.NameEn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEn.Location = new System.Drawing.Point(10, 165);
            this.NameEn.Name = "NameEn";
            this.NameEn.Size = new System.Drawing.Size(118, 24);
            this.NameEn.TabIndex = 40;
            this.NameEn.Text = "District:";
            // 
            // StreetTB
            // 
            this.StreetTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.StreetTB.Location = new System.Drawing.Point(134, 200);
            this.StreetTB.Name = "StreetTB";
            this.StreetTB.Size = new System.Drawing.Size(285, 32);
            this.StreetTB.TabIndex = 39;
            // 
            // NameAr
            // 
            this.NameAr.AutoSize = true;
            this.NameAr.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAr.Location = new System.Drawing.Point(10, 203);
            this.NameAr.Name = "NameAr";
            this.NameAr.Size = new System.Drawing.Size(94, 24);
            this.NameAr.TabIndex = 38;
            this.NameAr.Text = "Street:";
            // 
            // ContryCB
            // 
            this.ContryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ContryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ContryCB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ContryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContryCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.ContryCB.FormattingEnabled = true;
            this.ContryCB.Location = new System.Drawing.Point(134, 86);
            this.ContryCB.Name = "ContryCB";
            this.ContryCB.Size = new System.Drawing.Size(235, 32);
            this.ContryCB.TabIndex = 50;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(6, 89);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(106, 24);
            this.label_1.TabIndex = 49;
            this.label_1.Text = "Country:";
            // 
            // CityCB
            // 
            this.CityCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CityCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(134, 124);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(235, 32);
            this.CityCB.TabIndex = 51;
            // 
            // DiscRTB
            // 
            this.DiscRTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.DiscRTB.Location = new System.Drawing.Point(14, 306);
            this.DiscRTB.Name = "DiscRTB";
            this.DiscRTB.Size = new System.Drawing.Size(324, 113);
            this.DiscRTB.TabIndex = 52;
            this.DiscRTB.Text = "";
            // 
            // ZipCodeTB
            // 
            this.ZipCodeTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.ZipCodeTB.Location = new System.Drawing.Point(134, 238);
            this.ZipCodeTB.Name = "ZipCodeTB";
            this.ZipCodeTB.Size = new System.Drawing.Size(204, 32);
            this.ZipCodeTB.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Zip Code:";
            // 
            // AddCountryB
            // 
            this.AddCountryB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.AddCountryB.Location = new System.Drawing.Point(375, 86);
            this.AddCountryB.Name = "AddCountryB";
            this.AddCountryB.Size = new System.Drawing.Size(44, 32);
            this.AddCountryB.TabIndex = 55;
            this.AddCountryB.Text = "+";
            this.AddCountryB.UseVisualStyleBackColor = true;
            this.AddCountryB.Click += new System.EventHandler(this.AddCountryB_Click);
            // 
            // AddCityB
            // 
            this.AddCityB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.AddCityB.Location = new System.Drawing.Point(375, 124);
            this.AddCityB.Name = "AddCityB";
            this.AddCityB.Size = new System.Drawing.Size(44, 32);
            this.AddCityB.TabIndex = 56;
            this.AddCityB.Text = "+";
            this.AddCityB.UseVisualStyleBackColor = true;
            this.AddCityB.Click += new System.EventHandler(this.AddCityB_Click);
            // 
            // AddEditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 435);
            this.Controls.Add(this.AddCityB);
            this.Controls.Add(this.AddCountryB);
            this.Controls.Add(this.ZipCodeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiscRTB);
            this.Controls.Add(this.CityCB);
            this.Controls.Add(this.ContryCB);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.applyB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DistrictTB);
            this.Controls.Add(this.NameEn);
            this.Controls.Add(this.StreetTB);
            this.Controls.Add(this.NameAr);
            this.Name = "AddEditAddress";
            this.Text = "AddEditAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton applyB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DistrictTB;
        private System.Windows.Forms.Label NameEn;
        private System.Windows.Forms.TextBox StreetTB;
        private System.Windows.Forms.Label NameAr;
        private System.Windows.Forms.ComboBox ContryCB;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.ComboBox CityCB;
        private System.Windows.Forms.RichTextBox DiscRTB;
        private System.Windows.Forms.TextBox ZipCodeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCountryB;
        private System.Windows.Forms.Button AddCityB;
    }
}