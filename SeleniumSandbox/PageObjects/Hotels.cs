using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumSandbox.PageObjects
{
    class Hotels
    {
        private IWebDriver _driver;

        public Hotels(IWebDriver driver)
        {
            _driver = driver;
        }
            
    public void goToHotels()
    {
        _driver.Url = "https://www.phptravels.net/hotels";
    }

   public IWebElement Hotel
{
    get
    {
        return _driver.FindElements(By.TagName("a")).Where(e => e.Text.Contains("HOTEL")).FirstOrDefault();

            }
        }

        public IWebElement HotelDetails
        {
            get
            {
                return _driver.FindElements(By.TagName("button")).Where(e => e.Text.Contains("DETAILS")).FirstOrDefault();

            }
        }
        public IWebElement BookHotel
        {
            get
            {
                return _driver.FindElements(By.TagName("button")).Where(e => e.Text.Contains("BOOK NOW")).FirstOrDefault();

            }
        }
    }
}
