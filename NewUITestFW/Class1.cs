using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewUITestFW
{
    [TestFixture]
    public class Class1
    {
        private readonly IWebDriver _driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://executeautomation.com/demosite/Login.html";
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void Test()
        {
        }
    }
}
