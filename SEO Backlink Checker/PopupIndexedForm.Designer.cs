namespace SEO_Backlink_Checker
{
    partial class PopupIndexedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupIndexedForm));
            this.formSkin1 = new FlatTheme.FormSkin();
            this.flatClose1 = new FlatTheme.FlatClose();
            this.fIndexedLabel = new FlatTheme.FlatLabel();
            this.fIndexedListBox = new FlatTheme.FlatListBox();
            this.fExportTXTBtn = new FlatTheme.FlatButton();
            this.fExportCSVBTN = new FlatTheme.FlatButton();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.formSkin1.BorderColor = System.Drawing.Color.Green;
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.fIndexedLabel);
            this.formSkin1.Controls.Add(this.fIndexedListBox);
            this.formSkin1.Controls.Add(this.fExportTXTBtn);
            this.formSkin1.Controls.Add(this.fExportCSVBTN);
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
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Indexed Backlinks";
            this.formSkin1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(691, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 8;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // fIndexedLabel
            // 
            this.fIndexedLabel.AutoSize = true;
            this.fIndexedLabel.BackColor = System.Drawing.Color.Transparent;
            this.fIndexedLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fIndexedLabel.ForeColor = System.Drawing.Color.White;
            this.fIndexedLabel.Location = new System.Drawing.Point(10, 308);
            this.fIndexedLabel.Name = "fIndexedLabel";
            this.fIndexedLabel.Size = new System.Drawing.Size(142, 13);
            this.fIndexedLabel.TabIndex = 7;
            this.fIndexedLabel.Text = "Total Indexed Backlinks : 0";
            // 
            // fIndexedListBox
            // 
            this.fIndexedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fIndexedListBox.items = new string[] {
        ""};
            this.fIndexedListBox.Location = new System.Drawing.Point(13, 64);
            this.fIndexedListBox.Name = "fIndexedListBox";
            this.fIndexedListBox.SelectedColor = System.Drawing.Color.Red;
            this.fIndexedListBox.SelectedIndex = 0;
            this.fIndexedListBox.Size = new System.Drawing.Size(697, 184);
            this.fIndexedListBox.TabIndex = 6;
            this.fIndexedListBox.Text = "flatListBox1";
            // 
            // fExportTXTBtn
            // 
            this.fExportTXTBtn.BackColor = System.Drawing.Color.Transparent;
            this.fExportTXTBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fExportTXTBtn.ButtonImage = null;
            this.fExportTXTBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fExportTXTBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fExportTXTBtn.ImageHeight = 0;
            this.fExportTXTBtn.ImageLeft = 0;
            this.fExportTXTBtn.ImageTop = 0;
            this.fExportTXTBtn.ImageWidth = 0;
            this.fExportTXTBtn.Location = new System.Drawing.Point(147, 264);
            this.fExportTXTBtn.Name = "fExportTXTBtn";
            this.fExportTXTBtn.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fExportTXTBtn.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.fExportTXTBtn.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fExportTXTBtn.Rounded = false;
            this.fExportTXTBtn.Size = new System.Drawing.Size(129, 32);
            this.fExportTXTBtn.TabIndex = 5;
            this.fExportTXTBtn.Text = "Export as TXT";
            this.fExportTXTBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.fExportTXTBtn.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.fExportTXTBtn.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.fExportTXTBtn.Click += new System.EventHandler(this.btnExportIndexedtxt_Click);
            // 
            // fExportCSVBTN
            // 
            this.fExportCSVBTN.BackColor = System.Drawing.Color.Transparent;
            this.fExportCSVBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fExportCSVBTN.ButtonImage = null;
            this.fExportCSVBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fExportCSVBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fExportCSVBTN.ImageHeight = 0;
            this.fExportCSVBTN.ImageLeft = 0;
            this.fExportCSVBTN.ImageTop = 0;
            this.fExportCSVBTN.ImageWidth = 0;
            this.fExportCSVBTN.Location = new System.Drawing.Point(12, 264);
            this.fExportCSVBTN.Name = "fExportCSVBTN";
            this.fExportCSVBTN.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fExportCSVBTN.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.fExportCSVBTN.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fExportCSVBTN.Rounded = false;
            this.fExportCSVBTN.Size = new System.Drawing.Size(129, 32);
            this.fExportCSVBTN.TabIndex = 4;
            this.fExportCSVBTN.Text = "Export as CSV";
            this.fExportCSVBTN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.fExportCSVBTN.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.fExportCSVBTN.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.fExportCSVBTN.Click += new System.EventHandler(this.btnExportIndexedCsv_Click);
            // 
            // PopupIndexedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 339);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupIndexedForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indexed Backlinks";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.PopupIndexedForm_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatTheme.FormSkin formSkin1;
        private FlatTheme.FlatButton fExportTXTBtn;
        private FlatTheme.FlatButton fExportCSVBTN;
        private FlatTheme.FlatListBox fIndexedListBox;
        private FlatTheme.FlatLabel fIndexedLabel;
        private FlatTheme.FlatClose flatClose1;


    }
}