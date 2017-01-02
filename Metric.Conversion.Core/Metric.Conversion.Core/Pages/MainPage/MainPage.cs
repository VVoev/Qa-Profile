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
    public class MainPage
    {

        private readonly IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//div[@id='sideMenu']//a[@title='Time Conversion']")]
        public IWebElement TitleConversionLink { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
        }



        
    }

}
