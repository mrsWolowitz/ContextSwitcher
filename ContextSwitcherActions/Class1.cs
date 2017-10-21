using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextSwitcherActions
{
    public class Class1
    {
        public string DBPath { get; set; }
        public string Issue { get; set; }

        public Class1(string dbPath, string issue)
        {
            DBPath = dbPath;
            Issue = issue;
        }

        public void RestoreDB()
        { }

        public void GetVersion()
        { }

        public void GitCheckout()
        { }

        public void ReplaceWebConfig()
        { }

        public void ReplaceConnection()
        { }

        public void Build()
        { }
        
    }
}
