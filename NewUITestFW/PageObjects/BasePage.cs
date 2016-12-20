using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NewUITestFW.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
