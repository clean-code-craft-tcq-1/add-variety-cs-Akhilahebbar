namespace TypewiseAlert
{
   
    class ActiveMedCooling : ICoolingType
    {
        public int LimitLow { get { return 0; } }
        public int LimitHigh { get { return 40; } }
    }
    class ActivePassiveCooling : ICoolingType
    {
        public int LimitLow { get { return 0; } }
        public int LimitHigh { get { return 35; } }
    }
    class ActiveHiCooling : ICoolingType
    {
        public int LimitLow { get { return 0; } }
        public int LimitHigh { get { return 45; } }
    }


}
