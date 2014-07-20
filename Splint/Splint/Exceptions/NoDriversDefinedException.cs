using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Splint.Exceptions
{
    public sealed class NoDriversDefinedException : Exception
    {
        public NoDriversDefinedException()
        {

        }

        public override string ToString()
        {
            return string.Format("No drivers have been defined");
        }
    }
}
