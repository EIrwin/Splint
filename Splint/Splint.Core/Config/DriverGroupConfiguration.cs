using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Splint.Core.Drivers;

namespace Splint.Core.Config
{
    public sealed class DriverGroupConfiguration:IDriverGroupConfig
    {
        public void RegisterDriverGroups()
        {
            DriverGroup webDriverGroup = new DriverGroup("Web", "Drivers intended to test web UI")
            {
                Name = "Web",
                Description = "Drivers intended to test web UI",
                Drivers = new System.Collections.Generic.List<IWebDriver>()
                        {
                            new ChromeSplintDriver(),
                            new FirefoxSplintDriver(),
                            new InternetExplorerSplintDriver()
                        }
            };

            DriverGroupProvider.AddDriverGroup(webDriverGroup);
        }
    }
}
