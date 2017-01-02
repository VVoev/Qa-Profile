using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using FindAZip.Core.Pages;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Diagnostics;

namespace FindAZip.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private HomePage homepage;
        private CitiesListPage citiesListPage;
        private IWebDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            this.homepage = new HomePage(driver);
            this.citiesListPage = new CitiesListPage(driver);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.driver.Quit();
        }
        [TestMethod]
        public void PrintFirstTenCities()
        {
            this.homepage.Navigate();
            this.homepage.ClickOnTheUrlStartingWithTheFirstLetterOfTheName("Vlado");
            List<string> citiesUrls = this.citiesListPage.GetFirstTenCitiesUrls();
            foreach (var city in citiesUrls)
            {
                Console.WriteLine(city);
            }

        }
    }
}
