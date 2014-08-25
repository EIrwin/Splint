using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using Splint.Drivers;

namespace Splint.Core.Drivers
{
    public class InternetExplorerSplintDriver : InternetExplorerDriver,ISplintDriver
    {
        public IWebDriver WebDriver { get; set; }
        public DriverType Type { get; set; }
        public string Name { get; set; }
    }
}