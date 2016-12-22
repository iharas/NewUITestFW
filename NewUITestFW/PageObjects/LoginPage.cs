using NewUITestFW.Controls;
using NewUITestFW.Domain;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NewUITestFW.PageObjects
{
    public class LoginPage
    {
        [FindsBy(How = How.Name, Using = "UserName")] private IWebElement UserName;
        [FindsBy(How = How.Name, Using = "Password")] private IWebElement Password;
        [FindsBy(How = How.Name, Using = "Login")] private IWebElement LogIn;


        public LoginPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void Login(User user)
        {
            UserName.SendKeys(user.Name);
            Password.SendKeys(user.Password);
            LogIn.Submit();
        }

        public void Login(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            LogIn.Submit();
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }
    }
}
