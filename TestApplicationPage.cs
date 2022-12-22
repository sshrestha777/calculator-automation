using OpenQA.Selenium;
using System;

namespace calculator_automation
{
    internal class TestApplicationPage
    {
        private IWebDriver Driver { get; set; }
    

        public TestApplicationPage(IWebDriver driver)
        {
           Driver = driver;
        }

        public IWebElement Emailfield => Driver.FindElement(By.Id("email"));

        public IWebElement Passwordfield => Driver.FindElement(By.Id("password"));

        //public bool IsVisible { get; internal set; }


        //Driver.FindElement(By.Id("password")).Send
        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://dx26t1diyptna.cloudfront.net/");
        }

        internal void FillOutEmail(TestUser  user)
        {

            Emailfield.SendKeys(user.Email);
            Passwordfield.SendKeys(user.Password);
        }
    }
}