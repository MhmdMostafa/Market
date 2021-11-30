
namespace Market
{
    partial class WithCb
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
            this.CallingCodeTB = new System.Windows.Forms.TextBox();
            this.ShortcutTB = new System.Windows.Forms.TextBox();
            this.NameArTB = new System.Windows.Forms.TextBox();
            this.NameEnTB = new System.Windows.Forms.TextBox();
            this.ContinentCB = new System.Windows.Forms.ComboBox();
            this.AddEditBT = new MaterialSkin.Controls.MaterialButton();
            this.lable4 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CallingCodeTB
            // 
            this.CallingCodeTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.CallingCodeTB.Location = new System.Drawing.Point(182, 233);
            this.CallingCodeTB.Name = "CallingCodeTB";
            this.CallingCodeTB.Size = new System.Drawing.Size(280, 32);
            this.CallingCodeTB.TabIndex = 44;
            this.CallingCodeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CallingCodeTB_KeyPress);
            // 
            // ShortcutTB
            // 
            this.ShortcutTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.ShortcutTB.Location = new System.Drawing.Point(182, 195);
            this.ShortcutTB.Name = "ShortcutTB";
            this.ShortcutTB.Size = new System.Drawing.Size(280, 32);
            this.ShortcutTB.TabIndex = 43;
            // 
            // NameArTB
            // 
            this.NameArTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameArTB.Location = new System.Drawing.Point(182, 157);
            this.NameArTB.Name = "NameArTB";
            this.NameArTB.Size = new System.Drawing.Size(280, 32);
            this.NameArTB.TabIndex = 42;
            // 
            // NameEnTB
            // 
            this.NameEnTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.NameEnTB.Location = new System.Drawing.Point(182, 119);
            this.NameEnTB.Name = "NameEnTB";
            this.NameEnTB.Size = new System.Drawing.Size(280, 32);
            this.NameEnTB.TabIndex = 41;
            // 
            // ContinentCB
            // 
            this.ContinentCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ContinentCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ContinentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContinentCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.ContinentCB.FormattingEnabled = true;
            this.ContinentCB.Location = new System.Drawing.Point(182, 81);
            this.ContinentCB.Name = "ContinentCB";
            this.ContinentCB.Size = new System.Drawing.Size(280, 32);
            this.ContinentCB.TabIndex = 40;
            // 
            // AddEditBT
            // 
            this.AddEditBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEditBT.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddEditBT.Depth = 0;
            this.AddEditBT.HighEmphasis = true;
            this.AddEditBT.Icon = null;
            this.AddEditBT.Location = new System.Drawing.Point(398, 275);
            this.AddEditBT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddEditBT.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddEditBT.Name = "AddEditBT";
            this.AddEditBT.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddEditBT.Size = new System.Drawing.Size(64, 36);
            this.AddEditBT.TabIndex = 38;
            this.AddEditBT.Text = "edit";
            this.AddEditBT.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddEditBT.UseAccentColor = false;
            this.AddEditBT.UseVisualStyleBackColor = true;
            this.AddEditBT.Click += new System.EventHandler(this.AddEditBT_Click);
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.Location = new System.Drawing.Point(10, 236);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(166, 24);
            this.lable4.TabIndex = 37;
            this.lable4.Text = "Calling Code:";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_4.Location = new System.Drawing.Point(10, 198);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(118, 24);
            this.label_4.TabIndex = 36;
            this.label_4.Text = "Shortcut:";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(10, 160);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(106, 24);
            this.label_3.TabIndex = 35;
            this.label_3.Text = "Name Ar:";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(10, 122);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(106, 24);
            this.label_2.TabIndex = 34;
            this.label_2.Text = "Name En:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(10, 84);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(130, 24);
            this.lable1.TabIndex = 33;
            this.lable1.Text = "Continent:";
            // 
            // WithCb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 324);
            this.Controls.Add(this.CallingCodeTB);
            this.Controls.Add(this.ShortcutTB);
            this.Controls.Add(this.NameArTB);
            this.Controls.Add(this.NameEnTB);
            this.Controls.Add(this.ContinentCB);
            this.Controls.Add(this.AddEditBT);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.lable1);
            this.Name = "WithCb";
            this.Text = "WithCb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CallingCodeTB;
        private System.Windows.Forms.TextBox ShortcutTB;
        private System.Windows.Forms.TextBox NameArTB;
        private System.Windows.Forms.TextBox NameEnTB;
        private System.Windows.Forms.ComboBox ContinentCB;
        private MaterialSkin.Controls.MaterialButton AddEditBT;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label lable1;
    }
}