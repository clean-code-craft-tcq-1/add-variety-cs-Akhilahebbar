using System;
using System.Collections.Generic;
using System.Text;

namespace TypewiseAlert
{
   public class FakeAlert:IAlerter
    {
        public bool IsExecuted = false;
        public void AlertBreachType(Constants.BreachType breachType)
        {
            IsExecuted = true;
        }
    }
}
