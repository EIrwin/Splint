using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Splint.Core.Drivers
{
    public class DriverGroup : IDriverGroup
    {
        public List<IWebDriver> Drivers { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DriverGroup(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public DriverGroup(string name, string description, List<IWebDriver> drivers)
        {
            this.Name = name;
            this.Description = description;
            Drivers = drivers;
        }

        public void AddDriver(IWebDriver driver)
        {
            Drivers.Add(driver);
        }
    }
}
