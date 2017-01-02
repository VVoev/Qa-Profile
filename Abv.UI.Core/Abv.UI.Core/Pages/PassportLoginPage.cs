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
    public class PassportLoginPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://passport.abv.bg/app/profiles/login";
        private WebDriverWait wait;

        public PassportLoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(this.driver, this);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            this.LoginSection = new LoginSection(this.driver);
        }

        public LoginSection LoginSection { get; set; }
    }
}
