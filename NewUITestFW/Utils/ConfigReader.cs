using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewUITestFW.Utils
{
    class ConfigReader
    {
        public string InitializeTest()
        {
            return ConfigurationManager.AppSettings["appUrl"].ToString();
        }
    }
}
