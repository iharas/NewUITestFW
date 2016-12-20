using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NewUITestFW.PageObjects
{
    internal class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "UserName")] public IWebElement UserName;
        [FindsBy(How = How.Name, Using = "Password")] public IWebElement Password;
        [FindsBy(How = How.Name, Using = "Login")] public IWebElement LogIn;


        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
