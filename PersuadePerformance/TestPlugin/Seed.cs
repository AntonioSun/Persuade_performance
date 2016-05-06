using Microsoft.VisualStudio.TestTools.WebTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugin
{
    public class Seed : WebTestPlugin
    {
        string randomNumber;
        string randomString;
        public override void PreWebTest(object sender, PreWebTestEventArgs e)
        {
            randomNumber = generateRandomNumber();
            randomString = generateRandomString();
            e.WebTest.Context["seedString"] = randomString;            
            e.WebTest.Context["seedNumber"] = randomNumber;
            base.PreWebTest(sender, e);
        }

        public string generateRandomNumber()
        {
            Random rand = new Random();
            string[] random = new string[5];
            for (int i = 0; i < 5; i++)
            {
                random[i] = rand.Next(0, 4).ToString();
            }
            return string.Join("", random);
        }

        public string generateRandomString()
        {
            Random rand = new Random();
            string[] random = new string[5];
            for (int i = 0; i < 5; i++)
            {
                random[i] = rand.Next(0, 4).ToString();
            }
            return string.Join("", random);
        }
    }

}
