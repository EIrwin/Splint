using OpenQA.Selenium;

namespace Splint.Drivers
{
    public class FirefoxSplintDriver : ISplintDriver
    {
        public IWebDriver WebDriver { get; set; }
        public DriverType Type { get; set; }
        public string Name { get; set; }
    }
}