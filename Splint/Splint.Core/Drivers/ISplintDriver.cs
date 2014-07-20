using OpenQA.Selenium;
using Splint.Drivers;

namespace Splint.Core.Drivers
{
    public interface ISplintDriver
    {
        IWebDriver WebDriver { get; set; }
        DriverType Type { get; set; }
        string Name { get; set; }
    }
}