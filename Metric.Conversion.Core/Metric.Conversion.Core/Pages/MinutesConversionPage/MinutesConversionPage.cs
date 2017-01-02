using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric.Conversion.Core
{
    public class MinutesConversionPage
    {
        private readonly IWebDriver driver;

        public MinutesConversionPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.Id, Using = "007002000")]
        public IWebElement MinutesConversionLink { get; set; }

        [FindsBy(How = How.Id, Using = "007002001")]
        public IWebElement MinutesToSecondsConversionLink { get; set; }


        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]+ "/time-conversion.htm");
        }
    }
}
