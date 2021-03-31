using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    class PassiveCooling : ICoolingType
    {
        public int LowerLimit { get { return 0; } }
        public int UpperLimit { get { return 35; } }
    }
}
