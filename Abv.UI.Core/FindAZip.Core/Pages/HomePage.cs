using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Tests.Core;

namespace FindAZip.Core.Pages
{
   public class HomePage : NavigatableBasePage
    {

        public HomePage(IWebDriver driver) : base
            (driver, @"http://findazip.com/")
        {
        }

        public void ClickOnTheUrlStartingWithTheFirstLetterOfTheName(string name)
        {
            string citiesLinkXPathLocator = string.Format("//a[contains(@href,'city-zip-codes-{0}')]", name[0].ToString().ToLower());
            IWebElement citiesLink = this.driver.FindElement(By.XPath(citiesLinkXPathLocator));
            citiesLink.Click();
        }


    }
}
