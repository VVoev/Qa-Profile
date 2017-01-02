using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Tests.Core
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;       
        protected readonly WebDriverWait wait;

        public BasePage(IWebDriver driver,string url)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(this.driver, this);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            this.Url = url;
        }

        public string Url { get; private set; }
    }
}
