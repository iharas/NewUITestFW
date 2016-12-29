using System.IO;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using static NSelene.Selene;

namespace EATests
{
    public class BaseConfig
    {
        [SetUp]
        public void Init()
        {
            /*FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.FirefoxBinaryPath = Path.GetDirectoryName(Directory.GetCurrentDirectory());
                //@"C:\VS\Projects\NewUITestFW\NewUITestFW\bin\Debug\geckodriver.exe";
            SetWebDriver(new FirefoxDriver(service));*/
            SetWebDriver(new ChromeDriver());
        }

        [TearDown]
        public void TearDown()
        {
            GetWebDriver().Quit();
        }
    }
}
