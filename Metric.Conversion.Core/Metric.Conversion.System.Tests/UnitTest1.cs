using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Metric.Conversion.Core;

namespace Metric.Conversion.System.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private IWebDriver driver;
        private MainPage page;
        private WebDriverWait wait;
        private MinutesConversionPage minutesConversionPageageOne;
        private MinutesToSecondsConversionPage minutesToSecondsConversionPage;

        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            this.page = new MainPage(this.driver);
            this.minutesConversionPageageOne = new MinutesConversionPage(driver);
            this.minutesToSecondsConversionPage = new MinutesToSecondsConversionPage(driver);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.driver.Quit();
        }

        [TestMethod]
        public void ConvertMinutesToSeconds()
        {
            this.page.Navigate();
            this.page.TitleConversionLink.Click();
            this.minutesConversionPageageOne.MinutesConversionLink.Click();
            this.minutesConversionPageageOne.MinutesToSecondsConversionLink.Click();
            this.minutesToSecondsConversionPage.TypeMinutes(15);
            this.minutesToSecondsConversionPage.AssertSeconds(900);
            
        }
    }
}
