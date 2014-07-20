using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Splint.Drivers
{
    public enum DriverType
    {
        [Description("Internet Explorer")]
        InternetExplorer,

        [Description("Firefox")]
        Firefox,

        [Description("Chrome")]
        Chrome
    }
}
