using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace calculator_automation
{
    [TestClass]
    [TestCategory("TestApplication1")]
    public class TestApplication1
    {
        private IWebDriver Driver { get; set; }

        [TestMethod]
        public void TestMethod1()

        {
            var testUser = new TestUser();
            testUser.Email = "sam@gmail.com";
            testUser.Password = "Test@1234";
            Driver = GetChromeDriver();
            var testApplicationPage = new TestApplicationPage(Driver);
            testApplicationPage.GoTo();
            // Assert.IsTrue(testApplicationPage.IsVisible);

            testApplicationPage.FillOutEmail(testUser);

        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

    }
}
