using System;

namespace Splint.Core.Exceptions
{
    public sealed class DriverGroupNotFoundException:SystemException
    {
        private string _driverGroupName;
        public DriverGroupNotFoundException(string driverGroupName)
        {
            _driverGroupName = driverGroupName;
        }

        public override string ToString()
        {
            return string.Format("Unable to find DriverGroup: {0}", _driverGroupName);
        }
    }
}