﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Splint.Drivers;

namespace Splint.Core.Drivers
{
    public class FirefoxSplintDriver : FirefoxDriver,ISplintDriver
    {
        public DriverType Type { get; set; }
        public string Name { get; set; }
    }
}