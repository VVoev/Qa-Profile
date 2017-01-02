using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Telerik.Demos.ToolControl;

namespace Telerik.Demos.ToolTip.Tests
{
    [TestClass]
    public class ToolTipExample
    {
        private IWebDriver driver;
        private ToolTipRelativeToPage page;
        private WebDriverWait wait;

        //izpalnqva se predi testovete 
        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            this.page = new ToolTipRelativeToPage(this.driver);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.driver.Quit();
        }
        [TestMethod]
        public void ShowToolTipButtonHoveredStyles()
        {
            this.page.Navigate();
            this.page.ShowedToolTipButtonHover();
            this.page.AssertShowToolTipHoveredStyles();
        }
    }
}
