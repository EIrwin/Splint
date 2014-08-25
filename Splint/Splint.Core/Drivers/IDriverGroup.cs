using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Splint.Core.Drivers
{
    public interface IDriverGroup
    {
        List<IWebDriver> Drivers { get; set; }

        string Name { get; set; }

        string Description { get; set; }
    }
}
