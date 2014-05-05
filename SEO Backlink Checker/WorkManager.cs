using System;
using System.Collections.Generic;
using System.Text;

namespace SEO_Backlink_Checker
{
    public class WorkManager
    {

        List<String> liStrBacklinks = new List<string>();
        int int32ReturnedWork;
        public bool paused = false;
        public bool active = false;
        public WorkManager(List<String> liStrWork)
        {
            this.liStrBacklinks = liStrWork;
        }
        public String GetWork
        {
            get
            {
                if (int32ReturnedWork < liStrBacklinks.Count)
                {
                    return liStrBacklinks[int32ReturnedWork++];
                }
                return null;
            }
        }
        public bool Working
        {
            get
            {
                return int32ReturnedWork < liStrBacklinks.Count && !paused;
            }
        }
    }
}
