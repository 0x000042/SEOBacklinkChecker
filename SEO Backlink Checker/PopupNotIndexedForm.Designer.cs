namespace SEO_Backlink_Checker
{
    partial class PopupNotIndexedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupNotIndexedForm));
            this.flatClose1 = new FlatTheme.FlatClose();
            this.formSkin1 = new FlatTheme.FormSkin();
            this.fNotIndexedLabel = new FlatTheme.FlatLabel();
            this.flatButton2 = new FlatTheme.FlatButton();
            this.flatButton1 = new FlatTheme.FlatButton();
            this.fNotIndexedListBox = new FlatTheme.FlatListBox();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(683, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formSkin1.BorderColor = System.Drawing.Color.Red;
            this.formSkin1.Controls.Add(this.fNotIndexedLabel);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.fNotIndexedListBox);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Red;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Movable = false;
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(722, 339);
            this.formSkin1.TabIndex = 6;
            this.formSkin1.Text = "Not-Indexed Backlinks";
            this.formSkin1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            // 
            // fNotIndexedLabel
            // 
            this.fNotIndexedLabel.AutoSize = true;
            this.fNotIndexedLabel.BackColor = System.Drawing.Color.Transparent;
            this.fNotIndexedLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fNotIndexedLabel.ForeColor = System.Drawing.Color.White;
            this.fNotIndexedLabel.Location = new System.Drawing.Point(12, 314);
            this.fNotIndexedLabel.Name = "fNotIndexedLabel";
            this.fNotIndexedLabel.Size = new System.Drawing.Size(164, 13);
            this.fNotIndexedLabel.TabIndex = 4;
            this.fNotIndexedLabel.Text = "Total Not Indexed Backlinks : 0";
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.flatButton2.ButtonImage = null;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.ImageHeight = 0;
            this.flatButton2.ImageLeft = 0;
            this.flatButton2.ImageTop = 0;
            this.flatButton2.ImageWidth = 0;
            this.flatButton2.Location = new System.Drawing.Point(12, 259);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.flatButton2.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.flatButton2.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(129, 32);
            this.flatButton2.TabIndex = 3;
            this.flatButton2.Text = "Export as CSV";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.flatButton2.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.flatButton2.Click += new System.EventHandler(this.btnExportIndexedCsv_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.flatButton1.ButtonImage = null;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.ImageHeight = 0;
            this.flatButton1.ImageLeft = 0;
            this.flatButton1.ImageTop = 0;
            this.flatButton1.ImageWidth = 0;
            this.flatButton1.Location = new System.Drawing.Point(147, 259);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(51)))));
            this.flatButton1.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.flatButton1.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(129, 32);
            this.flatButton1.TabIndex = 2;
            this.flatButton1.Text = "Export as TXT";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.flatButton1.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.flatButton1.Click += new System.EventHandler(this.btnExportIndexedtxt_Click);
            // 
            // fNotIndexedListBox
            // 
            this.fNotIndexedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fNotIndexedListBox.items = new string[] {
        ""};
            this.fNotIndexedListBox.Location = new System.Drawing.Point(13, 69);
            this.fNotIndexedListBox.Name = "fNotIndexedListBox";
            this.fNotIndexedListBox.SelectedColor = System.Drawing.Color.Red;
            this.fNotIndexedListBox.SelectedIndex = 0;
            this.fNotIndexedListBox.Size = new System.Drawing.Size(697, 184);
            this.fNotIndexedListBox.TabIndex = 1;
            this.fNotIndexedListBox.Text = "flatListBox1";
            // 
            // PopupNotIndexedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 339);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupNotIndexedForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Indexed Backlinks";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.PopupNotIndexedForm_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatTheme.FlatClose flatClose1;
        private FlatTheme.FormSkin formSkin1;
        private FlatTheme.FlatButton flatButton2;
        private FlatTheme.FlatButton flatButton1;
        private FlatTheme.FlatListBox fNotIndexedListBox;
        private FlatTheme.FlatLabel fNotIndexedLabel;

    }
}