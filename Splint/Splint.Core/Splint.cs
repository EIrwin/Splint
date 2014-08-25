using System;
using System.Collections.Generic;
using Splint.Core.Drivers;
using Splint.Core.Exceptions;
using Splint.Drivers;

namespace Splint.Core
{
    public class Splint
    {
        private static IDictionary<DriverType, ISplintDriver> _drivers;
        private static Action _test;

        internal Splint(Action test)
        {
            _test = test;
            _drivers = new Dictionary<DriverType, ISplintDriver>();
        }

        public Splint WithDriver(DriverType driverType)
        {

            if (!_drivers.ContainsKey(driverType))
            {
                ISplintDriver driver = DriverFactory.CreateDriver(driverType);
                _drivers.Add(driverType, driver);
            }
            else
            {
                throw new DriverAlreadyDefinedException(driverType);
            }

            return this;
        }
        public Splint WithDrivers(DriverType[] driverTypes)
        {
            foreach (DriverType driverType in driverTypes)
            {
                if (!_drivers.ContainsKey(driverType))
                {
                    ISplintDriver driver = DriverFactory.CreateDriver(driverType);
                    _drivers.Add(driverType, driver);
                }
                else
                {
                    throw new DriverAlreadyDefinedException(driverType);
                }
            }

            return this;
        }
        public Splint WithAllDrivers()
        {
            WithDrivers(new[] {DriverType.Chrome, 
                DriverType.Firefox, 
                DriverType.InternetExplorer});

            return this;
        }

        public static Splint Test(Action test)
        {
            return new Splint(test);
        }

        public void Run()
        {
            if (_drivers.Count == 0)
                //throw new NoDriversDefinedException();

            _test();
        }
    }
}