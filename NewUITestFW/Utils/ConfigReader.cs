using System.Configuration;
using NewUITestFW.Controls;

namespace NewUITestFW.Utils
{
    internal class ConfigReader
    {
        public static string ReadProperty(string property)
        {
            return ConfigurationManager.AppSettings[property];
        }
    }
}
