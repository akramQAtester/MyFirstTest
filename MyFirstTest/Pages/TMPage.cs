using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyFirstTest.Pages
{
    class TMPage
    {

        public void createTM(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //Click create new button
            driver.FindElement(By.XPath("//a[contains(text(),'Create New')]")).Click();
            //expect delay
            Thread.Sleep(500);

            //Select time from dropdown
            driver.FindElement(By.XPath("//span[@class='k-input']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//li[normalize-space()='Time']")).Click();

            
            //input code
            driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("test1");
            //input test
            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("ahmed testing");
            // input price per unitand click save
            driver.FindElement(By.XPath("//body/div[@id='container']/form[@id='TimeMaterialEditForm']/div[1]/div[4]/div[1]/span[1]/span[1]/input[1]")).SendKeys("999");
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();

            //Console.WriteLine(driver.Url);
            // expect delay
            Thread.Sleep(5000);


            //verify create
            // Go to Last page
            IWebElement lastPage = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            lastPage.Click();

            // Verify if last row contains the record created

            IWebElement actualDecription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[3]"));

            if (actualDecription.Text != "ahmed testing")
            {
                Console.WriteLine("TM Test Passed  ");
            }
            else
            {
                Console.WriteLine("TM Test Failed ");
            }

        }
        public void editTM(IWebDriver driver)
        {
            // Click the edit Btn 

            IWebElement edit_Btn = driver.FindElement(By.XPath("//tbody/tr[2]/td[5]/a[1]"));
            edit_Btn.Click();

            // Edit the last result
            IWebElement edit_Descrpition = driver.FindElement(By.XPath("//input[@id='Code']"));
            edit_Descrpition.Clear();
            edit_Descrpition.SendKeys("L");

            Thread.Sleep(2000);

            // Save the updated record

            IWebElement save_btn = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            save_btn.Click();
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']")).Click();

            Thread.Sleep(3000);
            IWebElement edit_Test = driver.FindElement(By.XPath("//tbody/tr[2]/td[5]/a[1]"));

            if (edit_Test.Text != "L")
            {
                Console.WriteLine("Test Passed editing");
            }
            else
            {
                Console.WriteLine("Test Failed editing");


            }


        }
        public void deleteTM(IWebDriver driver)
        {
            // click delete (Deleting 2nd Row)
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            DeleteButton.Click();

            Thread.Sleep(5000);

            //Accept the Alert Button to delete from the record

            var alert_ok = driver.SwitchTo().Alert();

            alert_ok.Accept();

            Thread.Sleep(3000);

            // After deleted check e record again -> go to last page and verify the "delete" record

            //Verify the delete record is present or not

            IWebElement DeleteButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[4]"));

            if (DeleteButton1.Text != "$2,123.00")
            {
                Console.WriteLine("Test Passed for Deleting");
            }
            else
            {
                Console.WriteLine("Test Failed For deleting");
            }

        }


    }
}
