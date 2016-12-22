using NewUITestFW.Controls;
using NewUITestFW.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NewUITestFW
{
    internal class BaseTest
    {
        private static IWebDriver _driver;
        private readonly string _url = ConfigReader.ReadProperty("appUrl");

        [SetUp]
        public void SetUp()
        {
            _driver = new WebDriverFactory().GetDriver(Browsers.Chrome);
            _driver.Url = _url;
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
