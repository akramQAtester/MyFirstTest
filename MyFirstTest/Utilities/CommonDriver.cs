using MyFirstTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstTest.Utilities
{
    class CommonDriver
    {
        // init driver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginTm()
        {
            Console.WriteLine("Hello World!");


            // launch turnup portal
            driver = new ChromeDriver(@"C:\Users\");



            //page objects for login
            LoginPage loginObj = new LoginPage();
            loginObj.loginsteps(driver);


        }
        [OneTimeTearDown]
        public void FinalSteps()
        {
            //CLOSE.DRIVER
     //       driver.Close();
        }

    }
}

