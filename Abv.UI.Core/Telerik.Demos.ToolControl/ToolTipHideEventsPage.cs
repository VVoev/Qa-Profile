﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Demos.ToolControl
{
    public class ToolTipHideEvents
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://passport.abv.bg/app/profiles/login";
        private WebDriverWait wait;

        public ToolTipHideEvents(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(this.driver, this);
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'@abv.bg')]")]
        public IWebElement Camera1Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'@abv.bg')]")]
        public IWebElement Camera1ImageToolTip { get; set; }


    }
}
