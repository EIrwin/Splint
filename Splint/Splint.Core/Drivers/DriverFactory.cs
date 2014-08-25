using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Splint.Drivers;

namespace Splint.Core.Drivers
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
                        };
                    break;
                case DriverType.Firefox:
                    driver = new FirefoxSplintDriver()
                        {
                            Name = "Firefox",
                            Type = driverType,
                        };
                    break;
                case DriverType.InternetExplorer:
                    driver = new InternetExplorerSplintDriver()
                        {
                            Name = "Internet Explorer",
                            Type = driverType,
                        };
                    break;
                default:
                    throw new NotImplementedException(string.Format("Driver type not implemented:{0}", driverType));
            }

            return driver;
        }
    }
}