using Metric.Conversion.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class SecondsToMinutesCalculatorSteps
    {
        //private IWebDriver driver;
        //private MainPage page;
        //private WebDriverWait wait;
        //private MinutesConversionPage minutesConversionPageageOne;
        //private MinutesToSecondsConversionPage minutesToSecondsConversionPage;

        //[Then(@"close the chrome browser")]
        //public void ThenCloseTheChromeBrowser()
        //{
        //    this.driver.Close();
        //}

        //[Given]
        //public void GivenChromeSpaceBrowserIsOpen()
        //{
        //    this.driver = new ChromeDriver();
        //    this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //    this.page = new MainPage(this.driver);
        //    this.minutesConversionPageageOne = new MinutesConversionPage(driver);
        //    this.minutesToSecondsConversionPage = new MinutesToSecondsConversionPage(driver);
        //}




        //[Given]
        //public void GivenConversionSiteIsLoaded()
        //{
        //    this.page.Navigate();
        //}

        //[When]
        //public void WhenIPressTheTimeLink()
        //{
        //    this.page.TitleConversionLink.Click();
        //}

        //[When]
        //public void WhenThenPressMinutesLink()
        //{
        //                this.minutesConversionPageageOne.MinutesConversionLink.Click();

        //}

        //[When]
        //public void WhenThenPressTheMinutesToSecondsLink()
        //{
        //    this.minutesConversionPageageOne.MinutesToSecondsConversionLink.Click();

        //}

        //[When]
        //public void WhenType_P0_MinutesInTheBox(int minutes)
        //{
        //    this.minutesToSecondsConversionPage.TypeMinutes(15);
        //}

        //[Then]
        //public void ThenAssertThat_P0_SecondsWillBeDisplayed(int seconds)
        //{
        //    this.minutesToSecondsConversionPage.AssertSeconds(900);
        //}


        [Given]
        public void GivenConversionSiteIsLoaded()
        {
            App.MainPage.Navigate();
        }

        [When]
        public void WhenIPressTheTimeLink()
        {
            App.MainPage.TitleConversionLink.Click();
        }

        [When]
        public void WhenThenPressMinutesLink()
        {
            App.MinutesConversionPage.MinutesConversionLink.Click();
        }

        [When]
        public void WhenThenPressTheMinutesToSecondsLink()
        {
            App.MinutesConversionPage.MinutesToSecondsConversionLink.Click();

        }

        [When]
        public void WhenType_P0_MinutesInTheBox(int minutes)
        {
            App.MinutesToSecondsConversionPage.TypeMinutes(15);
        }

        [Then]
        public void ThenAssertThat_P0_SecondsWillBeDisplayed(int seconds)
        {
            App.MinutesToSecondsConversionPage.AssertSeconds(900);
        }
    }
}
