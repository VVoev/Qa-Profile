using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abv.UI.Core.Pages
{
    public class LoginSection
    {
        private readonly IWebDriver driver;

        public LoginSection(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameInput { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "loginBut")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Id, Using = "form.errors")]
        public IWebElement ErrorBox { get; set; }
    }
}
