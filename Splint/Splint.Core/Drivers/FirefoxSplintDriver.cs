using OpenQA.Selenium;
using Splint.Drivers;

namespace Splint.Core.Drivers
{
    public class FirefoxSplintDriver : ISplintDriver
    {
        public IWebDriver WebDriver { get; set; }
        public DriverType Type { get; set; }
        public string Name { get; set; }
    }
}