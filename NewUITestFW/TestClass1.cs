using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace NewUITestFW
{
    public class TestClass1
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }
    }
}
