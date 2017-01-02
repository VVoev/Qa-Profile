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
    public abstract class NavigatableBasePage : BasePage
    {

        public NavigatableBasePage(IWebDriver driver,string url) : base
            (driver,url)
        {                    
        }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.Url);
        }
    }
}
