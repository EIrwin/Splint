using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Splint.Core.Drivers
{
    public abstract class WebDriverFactory : IWebDriverFactory
    {
        public abstract IEnumerable<IWebDriver> GetDrivers();
    }
}
