using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace NewUITestFW.Controls
{
    public class WebDriverFactory
    {
        private IWebDriver _driver;

        public IWebDriver GetDriver(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    _driver = new ChromeDriver();
                    break;
                case Browsers.Firefox:
                    _driver = new FirefoxDriver();
                    break;
                case Browsers.IE:
                    _driver = new InternetExplorerDriver();
                    break;
                default:
                    throw new ArgumentException("Browser name is not valid.");
            }
            return _driver;
        }

        public void Close()
        {
            _driver?.Quit();
        }

        public IWebDriver GetDriverInstance()
        {
            return _driver;
        }
    }

    public enum Browsers
    {
        Chrome,
        Firefox,
        IE
    }
}
