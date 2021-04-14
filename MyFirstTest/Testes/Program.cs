using MyFirstTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;



namespace MyFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            // launch turnup portal
            IWebDriver driver = new ChromeDriver(@"C:\Users\");
            


            //page objects for login
            LoginPage loginObj = new LoginPage();
            loginObj.loginsteps(driver);

            // homje page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);


            // tm page object
            TMPage tmObj = new TMPage();
            tmObj.createTM(driver);
            tmObj.editTM(driver);
            tmObj.deleteTM(driver);
           


      

        }

    }
}
        