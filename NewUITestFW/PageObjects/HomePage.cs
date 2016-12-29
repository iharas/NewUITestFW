using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NewUITestFW.PageObjects
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//*[text()='Logout']")] private IWebElement LogOut;

        public bool IsAt => LogOut.Displayed;

        public LoginPage LogOutFromApp()
        {
            LogOut.Click();
            return new LoginPage();
        }
    }
}
