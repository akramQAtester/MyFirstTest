using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyFirstTest.Pages
{
    class HomePage
    { 
        public void navigateToTM(IWebDriver driver)

        {
            // identify administrator and click
            IWebElement Admin = driver.FindElement(By.CssSelector("div.navbar.navbar-inverse.navbar-fixed-top:nth-child(3) div.container div.navbar-collapse.collapse ul.nav.navbar-nav li.dropdown:nth-child(5) > a.dropdown-toggle"));
            Admin.Click();

            // identify time and material and click
            driver.FindElement(By.LinkText("Time & Materials")).Click();
            //expect5 delay
            Thread.Sleep(500);

        }
        public void navigateToCompanies(IWebDriver driver)

        {
            // identify administrator and click
          //  IWebElement Admin = driver.FindElement(By.CssSelector("div.navbar.navbar-inverse.navbar-fixed-top:nth-child(3) div.container div.navbar-collapse.collapse ul.nav.navbar-nav li.dropdown:nth-child(5) > a.dropdown-toggle"));
            //Admin.Click();

            // click companies
           // driver.FindElement(By.LinkText("company")).Click();
            // click companies - to-do
          //  expect delay
            Thread.Sleep(500);

        }
    }
}
