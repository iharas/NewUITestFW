using OpenQA.Selenium.Support.PageObjects;
using static NSelene.Selene;

namespace NewUITestFW.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage()
        {
            PageFactory.InitElements(GetWebDriver(), this);
        }
    }
}
