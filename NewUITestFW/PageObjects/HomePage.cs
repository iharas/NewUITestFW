using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewUITestFW.Controls;
using OpenQA.Selenium;

namespace NewUITestFW.PageObjects
{
    public class HomePage
    {
        public static bool IsAt {
            get
            {
                var logout = Driver.Instance.FindElement(By.XPath(".//span[text()='Logout']"));
                return logout.Displayed;
            }
        }
    }
}
