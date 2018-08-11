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
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement MyAccount
        {
            get
            {
                return _driver.FindElements(By.TagName("li")).Where(e => e.Text.Contains("MY ACCOUNT")).FirstOrDefault();
            }

        }
        public IWebElement Login
        {
            get
            {
                return _driver.FindElements(By.TagName("a")).Where(e => e.Text.Contains("Login")).FirstOrDefault();

            }
        }
      }
    }

   