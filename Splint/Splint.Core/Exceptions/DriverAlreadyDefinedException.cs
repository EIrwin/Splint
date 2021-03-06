﻿using System;
using Splint.Core.Extensions;
using Splint.Drivers;

namespace Splint.Core.Exceptions
{
    public sealed class DriverAlreadyDefinedException : SystemException
    {
        private DriverType _driverType;

        public DriverAlreadyDefinedException(DriverType driverType)
        {
            _driverType = driverType;
        }

        public override string ToString()
        {
            return string.Format("Driver has already been defined:{0}", _driverType.GetDescription());
        }
    }
}