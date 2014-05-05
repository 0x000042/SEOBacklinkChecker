using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;
using System.IO;

    public class SEOWebRequest
    {
        public string LastError;
        public bool LastOK = false;
        private HttpWebRequest req;
        public SEOWebRequest()
        {
           
        }
        public static void Init()
        {
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.DefaultConnectionLimit = 9999;
            WebRequest.DefaultWebProxy = (WebProxy)null;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        } 
        public string GET(string url,WebProxy proxy=null)
        { 
            LastOK = false;
            string s = string.Empty;
            req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1944.0 Safari/537.36";
            req.Proxy = (WebProxy)proxy;
            req.UseDefaultCredentials = false;
            req.KeepAlive = false;
            req.Timeout = 3000;
            try
            {
                using (StreamReader sr = new StreamReader(req.GetResponse().GetResponseStream()))
                {
                    LastOK = true;
                    return sr.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
    }
