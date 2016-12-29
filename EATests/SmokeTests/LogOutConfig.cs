using NewUITestFW.PageObjects;
using NUnit.Framework;

namespace EATests.SmokeTests
{
    class LogOutConfig : BaseTest
    {
        [Test]
        [Parallelizable]
        public void UserCanLogOutFromApplication()
        {
            OpenHomePage().LogOutFromApp();
            Assert.IsTrue(new LoginPage().IsAt, "Failed to login");
        }
    }
}
