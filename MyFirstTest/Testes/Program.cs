﻿using MyFirstTest.Pages;
using MyFirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;



namespace MyFirstTest
{

    [TestFixture] // collect of steps
    [Parallelizable] // faciltes to run test simultaneously
    class Program : CommonDriver
    {
        //static void Main(string[] args)
        //{

        //}


        [Test]
        public void CreateTMTest()
        {

           // home page object
             HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);


           // tm page object
             TMPage tmObj = new TMPage();
            tmObj.createTM(driver);
        }

        [Test]
        public void EditTMTest()
            {

                // home page object
                HomePage homeObj = new HomePage();
                homeObj.navigateToTM(driver);


                // tm page object
                TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);

            }
        [Test]
        public void DeleteTMTest()
            {

                // home page object
                HomePage homeObj = new HomePage();
                homeObj.navigateToTM(driver);


                // tm page object
                TMPage tmObj = new TMPage();
                tmObj.deleteTM(driver);
         }
        

    }
 }


