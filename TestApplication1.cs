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
        private IWebDriver Driver { get; set; } //( declare property)

        [TestMethod]
        public void TestMethod1()

        {
            var user1 = new User();
            user1.Email = "sam@gmail.com"; //(assign property value)
            user1.Password = "Test@1234"; //(assign property value)
            Driver = GetChromeDriver(); //( assign property value)

            var testApplicationPage = new LoginPageTest(Driver);
            testApplicationPage.GoTo();
            // Assert.IsTrue(testApplicationPage.IsVisible);

            testApplicationPage.FillOutLoginForm(user1);

        }

        [TestMethod]
        public void TestMethod2()

        {
            var user2 = new User();
            user2.Email = "suraj@gmail.com"; //(assign property value)
            user2.Password = "Password123"; //(assign property value)
            Driver = GetChromeDriver(); //( assign property value)

            var testApplicationPage = new LoginPageTest(Driver);
            testApplicationPage.GoTo();
            // Assert.IsTrue(testApplicationPage.IsVisible);

            testApplicationPage.FillOutLoginForm(user2);

        }

        private IWebDriver GetChromeDriver() // method returning IWebDriver
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

    }
}
