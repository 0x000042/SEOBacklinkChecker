namespace SEO_Backlink_Checker
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.flatForm = new FlatTheme.FormSkin();
            this.deadProxiesLabel = new FlatTheme.FlatLabel();
            this.workingproxiesLabel = new FlatTheme.FlatLabel();
            this.fLoadedProxiesLabel = new FlatTheme.FlatLabel();
            this.loadProxiesButton = new FlatTheme.FlatButton();
            this.loadProxiesCheckBox = new FlatTheme.FlatCheckBox();
            this.loadedBacklinksLabel = new FlatTheme.FlatLabel();
            this.logBox = new System.Windows.Forms.TextBox();
            this.backlinkListBox = new FlatTheme.FlatListBox();
            this.flatLabel4 = new FlatTheme.FlatLabel();
            this.threadCount = new FlatTheme.FlatNumeric();
            this.notIndexedLabel = new FlatTheme.FlatLabel();
            this.indexedLabel = new FlatTheme.FlatLabel();
            this.activeThreadsLabel = new FlatTheme.FlatLabel();
            this.btnShowNotIndexed = new FlatTheme.FlatButton();
            this.btnShowIndexed = new FlatTheme.FlatButton();
            this.checkBacklinks = new FlatTheme.FlatButton();
            this.loadBacklinks = new FlatTheme.FlatButton();
            this.flatClose1 = new FlatTheme.FlatClose();
            this.flatMini1 = new FlatTheme.FlatMini();
            this.checkedProxiesLabel = new FlatTheme.FlatLabel();
            this.flatForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatForm
            // 
            this.flatForm.BackColor = System.Drawing.Color.White;
            this.flatForm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.flatForm.BorderColor = System.Drawing.Color.DodgerBlue;
            this.flatForm.Controls.Add(this.checkedProxiesLabel);
            this.flatForm.Controls.Add(this.deadProxiesLabel);
            this.flatForm.Controls.Add(this.workingproxiesLabel);
            this.flatForm.Controls.Add(this.fLoadedProxiesLabel);
            this.flatForm.Controls.Add(this.loadProxiesButton);
            this.flatForm.Controls.Add(this.loadProxiesCheckBox);
            this.flatForm.Controls.Add(this.loadedBacklinksLabel);
            this.flatForm.Controls.Add(this.logBox);
            this.flatForm.Controls.Add(this.backlinkListBox);
            this.flatForm.Controls.Add(this.flatLabel4);
            this.flatForm.Controls.Add(this.threadCount);
            this.flatForm.Controls.Add(this.notIndexedLabel);
            this.flatForm.Controls.Add(this.indexedLabel);
            this.flatForm.Controls.Add(this.activeThreadsLabel);
            this.flatForm.Controls.Add(this.btnShowNotIndexed);
            this.flatForm.Controls.Add(this.btnShowIndexed);
            this.flatForm.Controls.Add(this.checkBacklinks);
            this.flatForm.Controls.Add(this.loadBacklinks);
            this.flatForm.Controls.Add(this.flatClose1);
            this.flatForm.Controls.Add(this.flatMini1);
            this.flatForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatForm.FlatColor = System.Drawing.Color.Red;
            this.flatForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatForm.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatForm.HeaderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.flatForm.HeaderMaximize = false;
            this.flatForm.Location = new System.Drawing.Point(0, 0);
            this.flatForm.Movable = false;
            this.flatForm.Name = "flatForm";
            this.flatForm.Size = new System.Drawing.Size(644, 505);
            this.flatForm.TabIndex = 13;
            this.flatForm.Text = "SEO Backlink Checker";
            this.flatForm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            // 
            // deadProxiesLabel
            // 
            this.deadProxiesLabel.AutoSize = true;
            this.deadProxiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.deadProxiesLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.deadProxiesLabel.ForeColor = System.Drawing.Color.Red;
            this.deadProxiesLabel.Location = new System.Drawing.Point(525, 483);
            this.deadProxiesLabel.Name = "deadProxiesLabel";
            this.deadProxiesLabel.Size = new System.Drawing.Size(88, 13);
            this.deadProxiesLabel.TabIndex = 31;
            this.deadProxiesLabel.Text = "Dead Proxies : 0";
            // 
            // workingproxiesLabel
            // 
            this.workingproxiesLabel.AutoSize = true;
            this.workingproxiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.workingproxiesLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.workingproxiesLabel.ForeColor = System.Drawing.Color.Green;
            this.workingproxiesLabel.Location = new System.Drawing.Point(321, 483);
            this.workingproxiesLabel.Name = "workingproxiesLabel";
            this.workingproxiesLabel.Size = new System.Drawing.Size(106, 13);
            this.workingproxiesLabel.TabIndex = 30;
            this.workingproxiesLabel.Text = "Working Proxies : 0";
            // 
            // fLoadedProxiesLabel
            // 
            this.fLoadedProxiesLabel.AutoSize = true;
            this.fLoadedProxiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.fLoadedProxiesLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fLoadedProxiesLabel.ForeColor = System.Drawing.Color.White;
            this.fLoadedProxiesLabel.Location = new System.Drawing.Point(15, 483);
            this.fLoadedProxiesLabel.Name = "fLoadedProxiesLabel";
            this.fLoadedProxiesLabel.Size = new System.Drawing.Size(100, 13);
            this.fLoadedProxiesLabel.TabIndex = 29;
            this.fLoadedProxiesLabel.Text = "Loaded proxies : 0";
            // 
            // loadProxiesButton
            // 
            this.loadProxiesButton.BackColor = System.Drawing.Color.Transparent;
            this.loadProxiesButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.loadProxiesButton.ButtonImage = null;
            this.loadProxiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadProxiesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadProxiesButton.ImageHeight = 0;
            this.loadProxiesButton.ImageLeft = 0;
            this.loadProxiesButton.ImageTop = 0;
            this.loadProxiesButton.ImageWidth = 0;
            this.loadProxiesButton.Location = new System.Drawing.Point(480, 112);
            this.loadProxiesButton.Name = "loadProxiesButton";
            this.loadProxiesButton.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loadProxiesButton.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.loadProxiesButton.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.loadProxiesButton.Rounded = false;
            this.loadProxiesButton.Size = new System.Drawing.Size(144, 33);
            this.loadProxiesButton.TabIndex = 28;
            this.loadProxiesButton.Text = "Load Proxies";
            this.loadProxiesButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.loadProxiesButton.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.loadProxiesButton.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.loadProxiesButton.Click += new System.EventHandler(this.loadProxiesButton_Click);
            // 
            // loadProxiesCheckBox
            // 
            this.loadProxiesCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loadProxiesCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.loadProxiesCheckBox.BorderColor = System.Drawing.Color.Red;
            this.loadProxiesCheckBox.Checked = false;
            this.loadProxiesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadProxiesCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loadProxiesCheckBox.Location = new System.Drawing.Point(324, 115);
            this.loadProxiesCheckBox.Name = "loadProxiesCheckBox";
            this.loadProxiesCheckBox.Options = FlatTheme.FlatCheckBox._Options.Style1;
            this.loadProxiesCheckBox.Size = new System.Drawing.Size(112, 22);
            this.loadProxiesCheckBox.TabIndex = 27;
            this.loadProxiesCheckBox.Text = "Use Proxies";
            this.loadProxiesCheckBox.TextColor = System.Drawing.Color.White;
            this.loadProxiesCheckBox.CheckedChanged += new FlatTheme.FlatCheckBox.CheckedChangedEventHandler(this.loadProxiesCheckbox_CheckedChanged);
            // 
            // loadedBacklinksLabel
            // 
            this.loadedBacklinksLabel.AutoSize = true;
            this.loadedBacklinksLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadedBacklinksLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.loadedBacklinksLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadedBacklinksLabel.Location = new System.Drawing.Point(165, 464);
            this.loadedBacklinksLabel.Name = "loadedBacklinksLabel";
            this.loadedBacklinksLabel.Size = new System.Drawing.Size(111, 13);
            this.loadedBacklinksLabel.TabIndex = 26;
            this.loadedBacklinksLabel.Text = "Loaded Backlinks : 0";
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(18, 308);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(614, 153);
            this.logBox.TabIndex = 25;
            // 
            // backlinkListBox
            // 
            this.backlinkListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.backlinkListBox.items = new string[] {
        ""};
            this.backlinkListBox.Location = new System.Drawing.Point(18, 156);
            this.backlinkListBox.Name = "backlinkListBox";
            this.backlinkListBox.SelectedColor = System.Drawing.Color.DodgerBlue;
            this.backlinkListBox.SelectedIndex = 0;
            this.backlinkListBox.Size = new System.Drawing.Size(614, 145);
            this.backlinkListBox.TabIndex = 24;
            this.backlinkListBox.Text = "flatListBox1";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(15, 125);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(140, 13);
            this.flatLabel4.TabIndex = 23;
            this.flatLabel4.Text = "Number of Threads to use";
            // 
            // threadCount
            // 
            this.threadCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.threadCount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.threadCount.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.threadCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.threadCount.ForeColor = System.Drawing.Color.White;
            this.threadCount.Location = new System.Drawing.Point(168, 115);
            this.threadCount.Maximum = ((long)(1000));
            this.threadCount.Minimum = ((long)(10));
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(144, 30);
            this.threadCount.TabIndex = 22;
            this.threadCount.Text = "flatNumeric1";
            this.threadCount.Value = ((long)(10));
            // 
            // notIndexedLabel
            // 
            this.notIndexedLabel.AutoSize = true;
            this.notIndexedLabel.BackColor = System.Drawing.Color.Transparent;
            this.notIndexedLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.notIndexedLabel.ForeColor = System.Drawing.Color.Red;
            this.notIndexedLabel.Location = new System.Drawing.Point(477, 464);
            this.notIndexedLabel.Name = "notIndexedLabel";
            this.notIndexedLabel.Size = new System.Drawing.Size(136, 13);
            this.notIndexedLabel.TabIndex = 21;
            this.notIndexedLabel.Text = "Not Indexed Backlinks : 0";
            // 
            // indexedLabel
            // 
            this.indexedLabel.AutoSize = true;
            this.indexedLabel.BackColor = System.Drawing.Color.Transparent;
            this.indexedLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.indexedLabel.ForeColor = System.Drawing.Color.Green;
            this.indexedLabel.Location = new System.Drawing.Point(321, 464);
            this.indexedLabel.Name = "indexedLabel";
            this.indexedLabel.Size = new System.Drawing.Size(114, 13);
            this.indexedLabel.TabIndex = 20;
            this.indexedLabel.Text = "Indexed Backlinks : 0";
            // 
            // activeThreadsLabel
            // 
            this.activeThreadsLabel.AutoSize = true;
            this.activeThreadsLabel.BackColor = System.Drawing.Color.Transparent;
            this.activeThreadsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.activeThreadsLabel.ForeColor = System.Drawing.Color.White;
            this.activeThreadsLabel.Location = new System.Drawing.Point(15, 464);
            this.activeThreadsLabel.Name = "activeThreadsLabel";
            this.activeThreadsLabel.Size = new System.Drawing.Size(95, 13);
            this.activeThreadsLabel.TabIndex = 19;
            this.activeThreadsLabel.Text = "Active Threads : 0";
            // 
            // btnShowNotIndexed
            // 
            this.btnShowNotIndexed.BackColor = System.Drawing.Color.Transparent;
            this.btnShowNotIndexed.BaseColor = System.Drawing.Color.Red;
            this.btnShowNotIndexed.ButtonImage = null;
            this.btnShowNotIndexed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowNotIndexed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowNotIndexed.ImageHeight = 0;
            this.btnShowNotIndexed.ImageLeft = 0;
            this.btnShowNotIndexed.ImageTop = 0;
            this.btnShowNotIndexed.ImageWidth = 0;
            this.btnShowNotIndexed.Location = new System.Drawing.Point(480, 66);
            this.btnShowNotIndexed.Name = "btnShowNotIndexed";
            this.btnShowNotIndexed.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnShowNotIndexed.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnShowNotIndexed.OnMouseUpColor = System.Drawing.Color.Red;
            this.btnShowNotIndexed.Rounded = false;
            this.btnShowNotIndexed.Size = new System.Drawing.Size(144, 33);
            this.btnShowNotIndexed.TabIndex = 18;
            this.btnShowNotIndexed.Text = "Show Not-Indexed";
            this.btnShowNotIndexed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnShowNotIndexed.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.btnShowNotIndexed.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.btnShowNotIndexed.Click += new System.EventHandler(this.btnShowNotIndexed_Click);
            // 
            // btnShowIndexed
            // 
            this.btnShowIndexed.BackColor = System.Drawing.Color.Transparent;
            this.btnShowIndexed.BaseColor = System.Drawing.Color.Green;
            this.btnShowIndexed.ButtonImage = null;
            this.btnShowIndexed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowIndexed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowIndexed.ImageHeight = 0;
            this.btnShowIndexed.ImageLeft = 0;
            this.btnShowIndexed.ImageTop = 0;
            this.btnShowIndexed.ImageWidth = 0;
            this.btnShowIndexed.Location = new System.Drawing.Point(324, 66);
            this.btnShowIndexed.Name = "btnShowIndexed";
            this.btnShowIndexed.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnShowIndexed.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnShowIndexed.OnMouseUpColor = System.Drawing.Color.Green;
            this.btnShowIndexed.Rounded = false;
            this.btnShowIndexed.Size = new System.Drawing.Size(144, 33);
            this.btnShowIndexed.TabIndex = 17;
            this.btnShowIndexed.Text = "Show Indexed";
            this.btnShowIndexed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnShowIndexed.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.btnShowIndexed.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.btnShowIndexed.Click += new System.EventHandler(this.btnShowIndexed_Click);
            // 
            // checkBacklinks
            // 
            this.checkBacklinks.BackColor = System.Drawing.Color.Transparent;
            this.checkBacklinks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.checkBacklinks.ButtonImage = null;
            this.checkBacklinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBacklinks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBacklinks.ImageHeight = 0;
            this.checkBacklinks.ImageLeft = 0;
            this.checkBacklinks.ImageTop = 0;
            this.checkBacklinks.ImageWidth = 0;
            this.checkBacklinks.Location = new System.Drawing.Point(168, 66);
            this.checkBacklinks.Name = "checkBacklinks";
            this.checkBacklinks.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkBacklinks.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkBacklinks.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.checkBacklinks.Rounded = false;
            this.checkBacklinks.Size = new System.Drawing.Size(144, 33);
            this.checkBacklinks.TabIndex = 16;
            this.checkBacklinks.Text = "Check Backlinks";
            this.checkBacklinks.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.checkBacklinks.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.checkBacklinks.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.checkBacklinks.Click += new System.EventHandler(this.checkBacklinks_Click);
            // 
            // loadBacklinks
            // 
            this.loadBacklinks.BackColor = System.Drawing.Color.Transparent;
            this.loadBacklinks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.loadBacklinks.ButtonImage = null;
            this.loadBacklinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBacklinks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadBacklinks.ImageHeight = 0;
            this.loadBacklinks.ImageLeft = 0;
            this.loadBacklinks.ImageTop = 0;
            this.loadBacklinks.ImageWidth = 0;
            this.loadBacklinks.Location = new System.Drawing.Point(12, 66);
            this.loadBacklinks.Name = "loadBacklinks";
            this.loadBacklinks.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loadBacklinks.OnMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.loadBacklinks.OnMouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.loadBacklinks.Rounded = false;
            this.loadBacklinks.Size = new System.Drawing.Size(144, 33);
            this.loadBacklinks.TabIndex = 15;
            this.loadBacklinks.Text = "Load Backlinks";
            this.loadBacklinks.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.loadBacklinks.TextLeftRightAlign = System.Drawing.StringAlignment.Center;
            this.loadBacklinks.TextTopDownAlign = System.Drawing.StringAlignment.Center;
            this.loadBacklinks.Click += new System.EventHandler(this.loadBacklinks_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(614, 16);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 14;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(587, 15);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 13;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // checkedProxiesLabel
            // 
            this.checkedProxiesLabel.AutoSize = true;
            this.checkedProxiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkedProxiesLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.checkedProxiesLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkedProxiesLabel.Location = new System.Drawing.Point(165, 483);
            this.checkedProxiesLabel.Name = "checkedProxiesLabel";
            this.checkedProxiesLabel.Size = new System.Drawing.Size(105, 13);
            this.checkedProxiesLabel.TabIndex = 32;
            this.checkedProxiesLabel.Text = "Checked Proxies : 0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 505);
            this.Controls.Add(this.flatForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backlink Checker";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.flatForm.ResumeLayout(false);
            this.flatForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatTheme.FormSkin flatForm;
        private FlatTheme.FlatClose flatClose1;
        private FlatTheme.FlatMini flatMini1;
        private System.Windows.Forms.TextBox logBox;
        private FlatTheme.FlatListBox backlinkListBox;
        private FlatTheme.FlatLabel flatLabel4;
        private FlatTheme.FlatNumeric threadCount;
        private FlatTheme.FlatLabel notIndexedLabel;
        private FlatTheme.FlatLabel indexedLabel;
        private FlatTheme.FlatLabel activeThreadsLabel;
        private FlatTheme.FlatButton btnShowNotIndexed;
        private FlatTheme.FlatButton btnShowIndexed;
        private FlatTheme.FlatButton checkBacklinks;
        private FlatTheme.FlatButton loadBacklinks;
        private FlatTheme.FlatLabel loadedBacklinksLabel;
        private FlatTheme.FlatButton loadProxiesButton;
        private FlatTheme.FlatCheckBox loadProxiesCheckBox;
        private FlatTheme.FlatLabel fLoadedProxiesLabel;
        public FlatTheme.FlatLabel deadProxiesLabel;
        public FlatTheme.FlatLabel workingproxiesLabel;
        public FlatTheme.FlatLabel checkedProxiesLabel;
    }
}

