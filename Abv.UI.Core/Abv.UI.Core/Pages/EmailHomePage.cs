using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abv.UI.Core.Pages
{
    public class EmailHomePage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://passport.abv.bg/app/profiles/login";
        private WebDriverWait wait;

        public EmailHomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(this.driver, this);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));           
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'@abv.bg')]")]
        public IWebElement WelcomeEmailDiv { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Невалидна сесия')]")]
        public IWebElement InvalidSession { get; set; }

        public void AssertWelcomeEmail(string userName)
        {
            string formatedExpectedUserName = string.Format("({0}@abv.bg)", userName);
            Assert.AreEqual(formatedExpectedUserName, this.WelcomeEmailDiv.Text, "emaila uspeshen");
        }

        public void AssertSuccesfullyLoggedOut()
        {
            Assert.IsTrue(InvalidSession.Displayed);
        }
    }
}
