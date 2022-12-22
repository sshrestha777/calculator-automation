using OpenQA.Selenium;
using System;

namespace calculator_automation
{
    internal class LoginPageTest
    {
        //private object myBool;

        private IWebDriver Driver { get; set; }


        public LoginPageTest(IWebDriver driver) // constructor as TestApplicationPage
        {
            Driver = driver;
        }

        public IWebElement Emailfield => Driver.FindElement(By.Id("email"));

        public IWebElement Passwordfield => Driver.FindElement(By.Id("password"));

        public IWebElement LogInText => Driver.FindElement(By.XPath("//h1[text()='Log in']"));

      
        


        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://dx26t1diyptna.cloudfront.net/");
        }

        internal void FillOutLoginForm(User user) // TestUser is class, user is parameter
        {
            Emailfield.SendKeys(user.Email);
            Passwordfield.SendKeys(user.Password);
        }

        //internal void FillOutEmailAndPassword(string email, string password) 
        //{
        //    Emailfield.SendKeys(email);
        //    Passwordfield.SendKeys(password);
        //}
    }
}