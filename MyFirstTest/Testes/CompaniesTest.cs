using MyFirstTest.Pages;
using MyFirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstTest.Testes
{
    [TestFixture]
    [Parallelizable]

    class CompaniesTest : CommonDriver
    {



        [Test]
        public void CreateCompanyTest()
        {

            // Home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);


            // Company page object
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.CreateCompany(driver);
        }
        [Test]
        public void EditCompanyTest()
        {

            // Home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);


            // Company page object
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.EditCompany(driver);
        }
        [Test]
        public void DeleteCompanyTest()
        {

            // Home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);


            // Company page object
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.DeleteCompany(driver);
        }



    }
}
