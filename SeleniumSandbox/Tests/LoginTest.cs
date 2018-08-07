using System;
using SeleniumSandbox.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSandbox
{
    public class LoginTest
    {
        private IWebDriver _driver = new ChromeDriver(@"C:\Users\myhan\Desktop\sandbox\SeleniumSandbox\SeleniumSandbox\bin\Debug\netcoreapp2.0");

        [Test]
        public void Login()
        {
            var _home = new Home(_driver);
            var _base = new BasePage(_driver);
            var _lg = new LoginPage(_driver);
            _home.goToHompage();
           // System.Threading.Thread.Sleep(5000);
            _base.MyAccount.Click();
            _base.Login.Click();
            System.Threading.Thread.Sleep(5000);
            _lg.email.SendKeys("marcus");



        }

   
    }

}