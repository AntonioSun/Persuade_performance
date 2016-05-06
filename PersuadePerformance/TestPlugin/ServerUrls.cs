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
            //Staging environment
            e.WebTest.Context["ServerUrl"] = "https://staging.brightwhistle.com";

            //Staging - Rails 4 environment
            //e.WebTest.Context["ServerUrl"] = "https://staging-new.brightwhistle.com";
            //e.WebTest.Context["ServerUrl"] = "https://preprod.brightwhistle.com";

            //Production environment
            //e.WebTest.Context["ServerUrl"] = "https://console.brightwhistle.com";
         
            base.PreWebTest(sender, e);
        }
    }
}
