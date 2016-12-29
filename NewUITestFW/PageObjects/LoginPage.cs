using NewUITestFW.Domain;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using static NSelene.Selene;

namespace NewUITestFW.PageObjects
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "UserName")] private IWebElement UserName;
        [FindsBy(How = How.Name, Using = "Password")] private IWebElement Password;
        [FindsBy(How = How.Name, Using = "Login")] private IWebElement LogIn;

        public bool IsAt => LogIn.Displayed;

        public void Login(User user)
        {
            UserName.SendKeys(user.Name);
            Password.SendKeys(user.Password);
            LogIn.Submit();
        }

        public HomePage Login(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            LogIn.Submit();
            return new HomePage();
        }

        public void GoTo()
        {
            GetWebDriver().Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }
    }
}
