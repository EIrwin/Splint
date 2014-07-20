using System.ComponentModel;
using System.Linq;
using Splint.Drivers;

namespace Splint.Core.Extensions
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
