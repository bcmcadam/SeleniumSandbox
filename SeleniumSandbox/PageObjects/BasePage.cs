using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumSandbox.PageObjects
{
    class BasePage
    {
        private ChromeDriver driver;

        public BasePage(ChromeDriver _driver)
        {
            _driver = driver;
        }

        public readonly By LOC_MY_ACCOUNT_DROPDOWN = By.CssSelector(".dropdown.-.toggle.go.-.text.-.right");


        public IWebElement myAccount
        {
            get
            {
                return driver.FindElements(LOC_MY_ACCOUNT_DROPDOWN).Where(e => e.Text.Contains("MY ACCOUNT")).First();
            }
        }
    }
}
