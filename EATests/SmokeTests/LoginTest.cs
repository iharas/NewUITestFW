using NewUITestFW.Controls;
using NewUITestFW.PageObjects;
using NUnit.Framework;

namespace EATests.SmokeTests
{
    class LoginTest
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [Test]
        public void AdminCanLogin()
        {
            var page = new LoginPage();
            LoginPage.GoTo();
            page.Login("admin", "admin");

            Assert.IsTrue(HomePage.IsAt, "Failed to login");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
