using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSandbox.PageObjects
{
    class Home
    {
        private IWebDriver _driver;

        public Home(IWebDriver driver)
        {
            _driver = driver;
        }

        public void goToHompage()
        {
            _driver.Url = "https://www.phptravels.net/";
        }


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
        }
    }
}

    