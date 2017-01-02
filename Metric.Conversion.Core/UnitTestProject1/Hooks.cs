using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using Metric.Conversion.Core;

namespace UnitTestProject1
{
    [Binding]
    public class Hooks
    {
       [BeforeTestRun]
       public static void TestRunInitialize()
        {
            App.Driver = new ChromeDriver();
            App.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            App.MainPage = new MainPage(App.Driver);
            App.MinutesConversionPage = new MinutesConversionPage(App.Driver);
            App.MinutesToSecondsConversionPage = new MinutesToSecondsConversionPage(App.Driver);
        }

        [AfterTestRun]
        public static void TestRunCleanUp()
        {
            App.Driver.Close();
        }
    }
}
