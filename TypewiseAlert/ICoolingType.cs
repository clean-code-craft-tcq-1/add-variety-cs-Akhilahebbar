using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
    public interface ICoolingType
    {
        int LimitLow { get; }

        int LimitHigh { get; }
    }
}
