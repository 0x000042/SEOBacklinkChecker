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
using System.Diagnostics;
using HtmlAgilityPack;

namespace SEO_Backlink_Checker
{
    public partial class mainForm :Form
    {
        public static int activeThreads = 0;
        public static List<String> backlinksList = new List<string>();
        public static List<String> indexedBacklinksList = new List<string>();
        public static List<String> not_indexedBacklinksList = new List<string>();
        public static bool useProxies = false;
        public static string queryString = "http://www.google.com/search?q=\"";
        public static PopupIndexedForm indexedForm = new PopupIndexedForm();
        public static PopupNotIndexedForm notindexedForm = new PopupNotIndexedForm();
        public static Random rnd = new Random();
        public static WorkManager work;
        public static ProxyManager proxyManager;
        public static SEOWebRequest seoReq = new SEOWebRequest();
        public mainForm()
        {
            SEOWebRequest.Init();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void loadBacklinks_Click(object sender, EventArgs e)
        {
            if(proxyManager != null && useProxies)
            {
                if(!proxyManager.Ready)
                {
                    Log.WriteLog("Please wait till all proxies are checked");
                    return;
                }
            }
            backlinksList.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.FilterIndex = 1;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                foreach(string s in File.ReadAllLines(ofd.FileName))
                {
                      Uri outUri;
                      if(Uri.TryCreate(s,UriKind.Absolute,out outUri))
                      {
                          backlinksList.Add(outUri.OriginalString);
                      }
                }
                backlinkListBox.AddRange(backlinksList.ToArray());
                loadedBacklinksLabel.Text = "Loaded backlinks : " + backlinksList.Count.ToString();              
            }
        }

        private void checkBacklinks_Click(object sender, EventArgs e)
        {
            if (work == null)
            {
                work = new WorkManager(backlinksList);
            }
            if(work.active)
            {
                work.active = false;
                checkBacklinks.Text = "Check Backlinks";
                work = new WorkManager(backlinksList);
                return;
            }
            new Thread(() =>
            {
                if (backlinksList.Count > 0)
                {
                    if (backlinksList.Count < (int)threadCount.Value)
                    {
                        threadCount.Value = backlinksList.Count;
                    }

                    for (int i = 0; i != threadCount.Value ; i++)
                    {
                        int threadID = i;
                        new Thread(() =>
                        {
                            Log.SetActiveThreadCount(true);
                           
                            SEOWebRequest threadReq = new SEOWebRequest();
                            while (work.Working)
                            {
                                lock (new object())
                                {
                                    if (!work.active)
                                    {
                                        Log.SetActiveThreadCount(false);
                                        return;
                                    }
                                    string s = work.GetWork;
                                    if (s != null)
                                    {
                                        string source = string.Empty;
                                        if (useProxies)
                                        {
                                            source=threadReq.GET(MakeQuery(s),proxyManager.WorkingProxy);
                                        }
                                        else
                                        {
                                            source = threadReq.GET(MakeQuery(s));
                                        }
                                        if (source != null)
                                        {
                                            
                                            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                                            doc.LoadHtml(source);
                                            HtmlNodeCollection searchResults = doc.DocumentNode.SelectNodes("//li[@class='g']");
                                            if (searchResults != null)
                                            {
                                                if (searchResults.Count > 0)
                                                {
                                                    indexedBacklinksList.Add(s);
                                                    Log.IncreaseIndexedCount();

                                                }
                                            }
                                            else
                                            {
                                                not_indexedBacklinksList.Add(s);
                                                Log.IncreaseNotIndexedCount();
                                            }
                                        }
                                        else
                                        {
                                            Log.WriteLog(string.Format("[Thread {0}] {1}", threadID.ToString("0000"), threadReq.LastError));
                                        }
                                    }
                                }
                            }
                            Log.SetActiveThreadCount(false);
                            return;
                        }).Start();
                    }
                    work.active = true;
                    checkBacklinks.Text = "Stop Checking";
                }
                
                else
                {
                    Log.WriteLog("Please load some backlinks");
                }
            }).Start();
            
        }

        public static string MakeQuery(string s)
        {
            return Uri.EscapeUriString(queryString+s+"\"");
        }
        public static class Log
        {
            public static mainForm f;
            public static void Init(mainForm m)
            {
                f = m;
            }
            public static void SetActiveThreadCount(bool inc)
            {
                if(inc)
                {
                    activeThreads++;
                }
                else
                {
                    activeThreads--;
                }
                f.activeThreadsLabel.Text = "Active Threads :" + activeThreads.ToString();
            }
            public static void IncreaseIndexedCount()
            {
                f.indexedLabel.Text = "Indexed backlinks : " + indexedBacklinksList.Count.ToString();
            }
            public static void IncreaseNotIndexedCount()
            {
                f.notIndexedLabel.Text = "Not indexed backlinks : " + not_indexedBacklinksList.Count.ToString();
            }
            public static void WriteLog(string t)
            {
                lock (f.logBox)
                {
                    f.Invoke((MethodInvoker)delegate
                    {
                        f.logBox.Text += t + "\r\n";
                        f.logBox.SelectionStart = f.logBox.Text.Length;
                        f.logBox.ScrollToCaret();
                    });
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Log.Init(this);
        }
         
        private void btnShowIndexed_Click(object sender, EventArgs e)
        {
            if(indexedForm.IsDisposed)
            {
                indexedForm = new PopupIndexedForm();
            }
            indexedForm.Show();
        }

        private void btnShowNotIndexed_Click(object sender, EventArgs e)
        {
            if (notindexedForm.IsDisposed)
                notindexedForm = new PopupNotIndexedForm();
            notindexedForm.Show();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadProxiesCheckbox_CheckedChanged(object sender)
        {
            this.loadProxiesButton.Enabled = this.Enabled;
            useProxies = !useProxies;
        }

        private void loadProxiesButton_Click(object sender, EventArgs e)
        {
            Log.WriteLog("Loading Proxies.. please wait while I check for banned ones");
            if(loadProxiesCheckBox.Checked)
            {

            }
            else
            {
                loadProxiesCheckBox.Checked = true;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                proxyManager = new ProxyManager(File.ReadAllLines(ofd.FileName));
            }
           
        }
    }
}
