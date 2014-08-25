using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Splint.Core.Config;

namespace Splint.Core.Attributes
{
    public class SplintTestFixture : TestFixtureAttribute
    {
        public SplintTestFixture()
        {
            InitializeDriverGroupConfiguration();
        }

        protected void InitializeDriverGroupConfiguration()
        {
            DriverGroupConfiguration configuration = new DriverGroupConfiguration();
            configuration.RegisterDriverGroups();
        }
    }
}
