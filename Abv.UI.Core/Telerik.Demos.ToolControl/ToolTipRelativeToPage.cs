using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Demos.ToolControl
{
   public class ToolTipRelativeToPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"http://demos.telerik.com/aspnet-ajax/tooltip/examples/relativeto/defaultcs.aspx";
        private WebDriverWait wait;

        public ToolTipRelativeToPage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(this.driver, this);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceholder1_RadButton1")]
        public IWebElement ShowToolTipButton { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
        
        public void ShowedToolTipButtonHover()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(this.ShowToolTipButton).Perform();
        }

        public void AssertShowToolTipHoveredStyles()
        {
            Assert.AreEqual("rgb(16, 143, 165)", this.ShowToolTipButton.GetCssValue("border-color"));
        } 

    }
}
