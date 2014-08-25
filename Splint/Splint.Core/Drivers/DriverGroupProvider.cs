using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Splint.Core.Drivers
{
    public sealed class DriverGroupProvider
    {
        public static IDictionary<string, IDriverGroup> DriverGroups = new Dictionary<string, IDriverGroup>();

        public static void AddDriverGroup(IDriverGroup driverGroup)
        {
            AddDriverGroup(driverGroup.Name, driverGroup);
        }

        public static void AddDriverGroup(string name, IDriverGroup driverGroup)
        {
            if (!DriverGroups.ContainsKey(name))
                DriverGroups.Add(name, driverGroup);
        }

        public static void RemoveDriverGroup(IDriverGroup driverGroup)
        {
            RemoveDriverGroup(driverGroup.Name);
        }

        public static void RemoveDriverGroup(string name)
        {
            if (DriverGroups.ContainsKey(name))
                DriverGroups.Remove(name);
        }

        public static IDriverGroup GetDriverGroup(string name)
        {
            IDriverGroup driverGroup = default(IDriverGroup);

            if (DriverGroups.ContainsKey(name))
                driverGroup =  DriverGroups[name];

            return driverGroup;
        }
    }
}
