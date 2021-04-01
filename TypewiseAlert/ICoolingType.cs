using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public interface ICoolingType
    {
        int LowerLimit { get; }

        int UpperLimit { get; }
    }
}
