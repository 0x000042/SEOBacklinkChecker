using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

    public class ProxyManager
    {
        
        private Random rnd = new Random();
        public int checkedCount = 1;
        public List<WebProxy> proxiesList = new List<WebProxy>();
        public List<WebProxy> workingProxiesList = new List<WebProxy>();
        public List<WebProxy> deadProxiesList = new List<WebProxy>();
        public ProxyManager(string[] proxies)
        {
            SEOWebRequest.Init();
            WebProxy proxyBuffer;
            foreach(string s in proxies)
            {
                string[] data = s.Split(':');
                proxyBuffer = new WebProxy(data[0], Int32.Parse(data[1]));
                if(data.Length==4)
                {
                    proxyBuffer.UseDefaultCredentials=false;
                    proxyBuffer.Credentials = new NetworkCredential(data[2], data[3]);
                }
                proxiesList.Add(proxyBuffer);
            }
           
            foreach(WebProxy proxy in proxiesList)
            {
                
                new Thread(() =>
                {
                    SEOWebRequest req = new SEOWebRequest();
                    string s = req.GET("http://www.google.com", proxy);
                    if (req.LastOK)
                    {
                        workingProxiesList.Add(proxy);
                    }
                    IncreaseCount();
                }).Start();
            }
        }
        private void IncreaseCount()
        {
            checkedCount++;
            SEO_Backlink_Checker.mainForm.Log.f.checkedProxiesLabel.Text = "Checked Proxies : " + (checkedCount - 1).ToString();
            SEO_Backlink_Checker.mainForm.Log.f.workingproxiesLabel.Text = "Working Proxies : " + WorkingCount.ToString();
            if (Ready)
            {
                SEO_Backlink_Checker.mainForm.Log.WriteLog("All proxies checked ");
                SEO_Backlink_Checker.mainForm.Log.f.deadProxiesLabel.Text = "Dead Proxies : " + DeadCount.ToString();
            }  
        }
        public WebProxy WorkingProxy
        {
            get
            {
                return workingProxiesList[rnd.Next(workingProxiesList.Count - 1)];
            }
        }
        public int WorkingCount
        {
            get
            {
                return workingProxiesList.Count;
            }
        }
        public int DeadCount
        {
            get
            {
                return (proxiesList.Count - workingProxiesList.Count);
            }
        }
        public bool Ready
        {
            get
            {
                
                return (checkedCount > proxiesList.Count);
            }
        }
    }
