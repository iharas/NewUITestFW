using System.Threading;
using NewUITestFW.PageObjects;
using NUnit.Framework;

namespace EATests.SmokeTests
{
    class LoginTest : BaseTest
    {
        [Test]
        [Parallelizable]
        public void AdminCanLogin()
        {
            OpenHomePage();
            Thread.Sleep(5000);
            Assert.IsTrue(new HomePage().IsAt, "Failed to login");
        }       
    }
}
