using System;
using SeleniumSandbox.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSandbox
{
    public class LoginTest
    {
        private  IWebDriver _driver = new ChromeDriver(@"C:\Users\myhan\Desktop\sandbox\SeleniumSandbox\SeleniumSandbox\bin\Debug\netcoreapp2.0");

        [Test]
        public void Login()
        {
            var _home = new Home(_driver);
            _home.goToHompage();

            
        }
    }
}
