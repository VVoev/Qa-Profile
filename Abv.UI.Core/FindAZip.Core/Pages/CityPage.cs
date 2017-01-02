using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Tests.Core;

namespace FindAZip.Core.Pages
{
   public class CityPage : BasePage
    {
        public CityPage(IWebDriver driver) : base
            (driver, @"http://findazip.com/")
        {
        }
    }
}
