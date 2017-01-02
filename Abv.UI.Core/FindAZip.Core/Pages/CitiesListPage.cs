using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Tests.Core;

namespace FindAZip.Core.Pages
{
  public  class CitiesListPage : BasePage
    {
        public CitiesListPage(IWebDriver driver) : base
            (driver, @"http://findazip.com/")
        {
        }

        public List<string> GetFirstTenCitiesUrls()
        {
        
            var citiesLinks = this.driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[3]/table[1]/tbody/tr/td/table[2]/tbody/tr/td[3]/table[2]/tbody/tr[4]")).FindElements(By.TagName("a"));
            List<string> results = new List<string>();
            int i = 0;
            foreach (var item in citiesLinks)
            {
                results.Add(item.GetAttribute("href"));
                i++;
                if (i == 10)
                {
                    break;
                }

            }
            return results;
        }


    }
}
