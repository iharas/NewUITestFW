using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewUITestFW.Controls;
using NewUITestFW.DemoQAPages;
using NUnit.Framework;

namespace DemoQATests.Smokes
{
    class RegisterTest
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [Test]
        public void NewUserCanBeRegistered()
        {
            new RegistrationPage();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
