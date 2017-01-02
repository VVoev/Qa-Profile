using Metric.Conversion.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public static class App
    {
        public static IWebDriver Driver { get; set; }
        public static MainPage MainPage { get; set; }
        public static MinutesConversionPage MinutesConversionPage { get; set; }
        public static MinutesToSecondsConversionPage MinutesToSecondsConversionPage { get; set; }
    }
}
