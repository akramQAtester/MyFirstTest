using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyFirstTest.Pages
{
    class LoginPage
    {

        public void loginsteps(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Maximize browser

            driver.Manage().Window.Maximize();

            try
            {




                // identify and enter username

                IWebElement Username = driver.FindElement(By.Id("UserName"));
                Username.SendKeys("hari");


                //identify and enter password
                IWebElement password = driver.FindElement(By.Id("Password"));  // note most cases its note ID, it could xpath or css etc
                password.SendKeys("123123");



                Thread.Sleep(1000);
                // identify and click login button
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();

            }

            catch(Exception msg)
            {
                Assert.Fail("test Failed at login page", msg.Message);
            }


            //driver.manager
            // validate if user is logged in successfully

            IWebElement addnewjobi = driver.FindElement(By.XPath("//*[@id='addnewjob']"));

            if (addnewjobi.Text == "Add New Job")
            {

                Console.WriteLine("Logged in successfully, test passed");

            }
            else
            {
                Console.WriteLine("login failed, Test failed");

            }
        }
    }
}