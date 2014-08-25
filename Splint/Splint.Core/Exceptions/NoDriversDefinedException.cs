using System;

namespace Splint.Core.Exceptions
{
    public sealed class NoDriversDefinedException:SystemException
    {
        public override string ToString()
        {
            return "No drivers were found";
        }
    }
}