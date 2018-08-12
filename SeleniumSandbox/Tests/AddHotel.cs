using System;
using SeleniumSandbox.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSandbox
{
    public class AddHotel
    {
        private IWebDriver _driver = new ChromeDriver(@"C:\Users\myhan\Desktop\sandbox\SeleniumSandbox\SeleniumSandbox\bin\Debug\netcoreapp2.0");

        [Test]
        public void Hotel()
        {
            var _home = new Home(_driver);
            var _base = new BasePage(_driver);
            var _lg = new LoginPage(_driver);
            var _hotel = new Hotels(_driver);
            _home.goToHompage();
            _hotel.Hotel.Click();
            _hotel.HotelDetails.Click();
           // _hotel.BookHotel.Click();
        }
    }
}