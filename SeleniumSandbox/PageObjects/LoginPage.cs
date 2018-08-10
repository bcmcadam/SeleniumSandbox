﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumSandbox.PageObjects
{
    class LoginPage
    {
        private IWebDriver _driver;

        public
            LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement email
        {
            get
            {
                return _driver.FindElements(By.TagName("input"))[0];

            }
        }
    }
}
    