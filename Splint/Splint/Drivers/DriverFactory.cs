using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Splint.Drivers
{
    public static class DriverFactory
    {
        public static ISplintDriver CreateDriver(DriverType driverType)
        {
            ISplintDriver driver;

            switch (driverType)
            {
                case DriverType.Chrome:
                    driver = new ChromeSplintDriver()
                        {
                            Name = "Chrome",
                            Type = driverType,
                            WebDriver = new ChromeDriver()
                        };
                    break;
                case DriverType.Firefox:
                    driver = new FirefoxSplintDriver()
                        {
                            Name = "Firefox",
                            Type = driverType,
                            WebDriver = new FirefoxDriver()
                        };
                    break;
                case DriverType.InternetExplorer:
                    driver = new InternetExplorerSplintDriver()
                        {
                            Name = "Internet Explorer",
                            Type = driverType,
                            WebDriver = new InternetExplorerDriver()
                        };
                    break;
                default:
                    throw new NotImplementedException(string.Format("Driver type not implemented:{0}", driverType));
            }

            return driver;
        }
    }
}