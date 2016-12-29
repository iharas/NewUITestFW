using NewUITestFW.PageObjects;
using static NSelene.Selene;

namespace EATests
{
    class BaseTest : BaseConfig
    {
        public HomePage OpenHomePage()
        {
            GetWebDriver().Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            new LoginPage().Login("admin", "admin");
            return new HomePage();
        }
    }
}
