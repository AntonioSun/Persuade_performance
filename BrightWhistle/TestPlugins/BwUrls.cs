using Microsoft.VisualStudio.TestTools.WebTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugin
{
    public class ServerUrls : WebTestPlugin
    {
        public override void PreWebTest(object sender, PreWebTestEventArgs e)
        {
            e.WebTest.Context["UIServerUrl"] = "https://staging.brightwhistle.com";
            //e.WebTest.Context["UIServerUrl"] = "https://staging-new.brightwhistle.com";
            //e.WebTest.Context["UIServerUrl"] = "https://console.brightwhistle.com";
            base.PreWebTest(sender, e);
        }
    }
}