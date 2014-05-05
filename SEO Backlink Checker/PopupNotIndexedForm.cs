using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Net;

namespace SEO_Backlink_Checker
{
    public partial class PopupNotIndexedForm : Form
    {
        public PopupNotIndexedForm()
        {
            InitializeComponent();
        }

        private void btnExportIndexedtxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (.txt)|*.txt";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                TextWriter tw = new StreamWriter(sfd.FileName);
                foreach (string item in mainForm.not_indexedBacklinksList)
                {
                    tw.WriteLine(item.ToString());
                }
                MessageBox.Show("Indexed backlinks are exported", "Start Dialog", MessageBoxButtons.OK);
                tw.Close();
            }
        }

        private void btnExportIndexedCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (.csv)|*.csv";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                TextWriter tw = new StreamWriter(sfd.FileName);
                foreach (string item in mainForm.not_indexedBacklinksList)
                {
                    tw.WriteLine(item.ToString());
                }
                MessageBox.Show("Indexed backlinks are exported", "Start Dialog", MessageBoxButtons.OK);
                tw.Close();
            }
        }

        private void PopupNotIndexedForm_Load(object sender, EventArgs e)
        {
            fNotIndexedListBox.AddRange(mainForm.not_indexedBacklinksList.ToArray());
            fNotIndexedLabel.Text = "Not Indexed backlinks: " + mainForm.not_indexedBacklinksList.Count.ToString();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
