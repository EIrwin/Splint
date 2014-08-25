using System;
using System.Collections.Generic;
using System.Linq;
using Splint.Core.Drivers;
using Splint.Core.Exceptions;
using Splint.Drivers;

namespace Splint.Core
{
    public class Splint
    {
        private static IDictionary<string, ISplintDriver> _drivers;
        private static Action _test;

        internal Splint(Action test)
        {
            _test = test;
            _drivers = new Dictionary<string, ISplintDriver>();
        }

        public Splint WithDriver(DriverType driverType)
        {
            ISplintDriver driver = DriverFactory.CreateDriver(driverType);

            if (!_drivers.ContainsKey(driver.Name))
                _drivers.Add(driver.Name, driver);
            else
                throw new DriverAlreadyDefinedException(driverType);

            return this;
        }

        public Splint WithDrivers(DriverType[] driverTypes)
        {
            driverTypes.ToList()
                       .ForEach(driverType => WithDriver(driverType));
            return this;
        }

        public Splint WithAllDrivers()
        {
            WithDrivers(new[] {DriverType.Chrome, 
                DriverType.Firefox, 
                DriverType.InternetExplorer});

            return this;
        }

        public Splint WithDriverGroup(string driverGroupName)
        {
            IDriverGroup driverGroup = DriverGroupProvider.GetDriverGroup(driverGroupName);

            if (driverGroup == null)
                throw new DriverGroupNotFoundException(driverGroupName);

            driverGroup.Drivers.ForEach(driver =>
                {
                    if (!_drivers.ContainsKey(driver.Name))
                        _drivers.Add(driver.Name, driver);
                });

            return this;
        }

        public Splint WithDriverGroups(params string[] driverGroupNames)
        {
            driverGroupNames.ToList().ForEach(driverGroupName => WithDriverGroup(driverGroupName));

            return this;
        }

        public static Splint Test(Action test)
        {
            return new Splint(test);
        }

        public void Run()
        {
            if (_drivers.Count == 0)
                throw new NoDriversDefinedException();

            _test();
        }
    }
}