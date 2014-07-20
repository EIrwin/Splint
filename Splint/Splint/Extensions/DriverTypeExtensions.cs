using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Splint.Drivers;

namespace Splint.Extensions
{
    public static class DriverTypeExtensions
    {
        public static string GetDescription(this DriverType driverType)
        {
            DescriptionAttribute descriptionAttribute =
                (DescriptionAttribute)driverType.GetType().GetCustomAttributes(typeof(DescriptionAttribute), false).First();

            return descriptionAttribute.Description;
        }
    }
}
