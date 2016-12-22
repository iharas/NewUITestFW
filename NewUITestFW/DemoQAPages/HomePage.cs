using NewUITestFW.Controls;
using OpenQA.Selenium;

namespace NewUITestFW.DemoQAPages
{
    class HomePage
    {

        public RegistrationPage OpenRegistrationPage()
        {
            var reg = Driver.Instance.FindElement(By.XPath(""));
            reg.Click();
            return new RegistrationPage();
        }
    }
}
