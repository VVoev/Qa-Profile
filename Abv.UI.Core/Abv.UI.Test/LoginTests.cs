using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Abv.UI.Core.Pages;

namespace Abv.UI.Test
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver driver;
        private LoginPage page;
        private WebDriverWait wait;
        private EmailHomePage emailHomePage;

        //izpalnqva se predi testovete 
        [TestInitialize]
        public void TestInit()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            this.page = new LoginPage(this.driver);
            this.emailHomePage = new EmailHomePage(this.driver);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.driver.Quit();
        }

        [TestMethod]
        public void LoginHappyPath()
        {
            this.page.Login("combomax", "t64t64t64");
            this.emailHomePage.AssertWelcomeEmail("combomax");
        }

        [TestMethod]
        public void LogOutHappyPath()
        {
            this.page.Login("combomax", "t64t64t64");
            this.emailHomePage.AssertWelcomeEmail("combomax");
            this.page.LogOut();
            this.emailHomePage.AssertSuccesfullyLoggedOut();

        }

    }
}
