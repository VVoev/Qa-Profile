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
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://www.abv.bg/";
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(this.driver, this);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            this.LoginSection = new LoginSection(this.driver);
        }

        public LoginSection LoginSection { get; set; }

        public void Login(string username,string password)
        {
            this.driver.Navigate().GoToUrl(this.url);
            this.LoginSection.UsernameInput.SendKeys(username);
            this.LoginSection.PasswordInput.SendKeys(password);
            this.LoginSection.LoginButton.Click();
        }
        public void LogOut()
        {
            this.driver.Manage().Cookies.DeleteAllCookies();
            this.driver.Navigate().Refresh();
            //this.wait.Until((IWebDriver driver) =>
            //{
            //    return this.driver.Url.Equals("http://www.gbg.bg/?a");
            //});
        }
    }
}
