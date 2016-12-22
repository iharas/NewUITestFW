using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewUITestFW.Controls
{
    class Button
    {
        private IWebDriver _driver;

        public Button(IWebDriver driver, Locator locator)
        {
            _driver = new WebDriverFactory().GetDriver(Browsers.Chrome);
        }


    }
}
