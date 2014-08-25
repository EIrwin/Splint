using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Splint.Drivers;

namespace Splint.Core.Drivers
{
    public class ChromeSplintDriver : ChromeDriver,ISplintDriver
    {
        public DriverType Type { get; set; }
        public string Name { get; set; }
    }
}