using Microsoft.VisualStudio.TestTools.UnitTesting;
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
   public class MinutesToSecondsConversionPage
    {
        private readonly IWebDriver driver;

        public MinutesToSecondsConversionPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.Id, Using = "argumentConv1")]
        public IWebElement MinutesInput { get; set; }

        [FindsBy(How = How.Id, Using = "answer")]
        public IWebElement Answer { get; set; }

        public void TypeMinutes(int minutes)
        {
            this.MinutesInput.SendKeys(minutes.ToString());
        }
        public void AssertSeconds(int seconds)
        {
            Assert.IsTrue(this.Answer.Text.Contains(seconds.ToString()));
        }
    }
}
