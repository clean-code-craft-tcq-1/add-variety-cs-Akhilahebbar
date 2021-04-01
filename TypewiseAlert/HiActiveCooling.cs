namespace TypewiseAlert
{
    class ActivePassiveCooling : ICoolingType
    {
        public int LowerLimit { get { return 0; } }
        public int UpperLimit { get { return 35; } }
    }
    class ActiveHiCooling : ICoolingType
    {
        public int LowerLimit { get { return 0; } }
        public int UpperLimit { get { return 45; } }
    }
    class ActiveMedCooling : ICoolingType
    {
        public int LowerLimit { get { return 0; } }
        public int UpperLimit { get { return 40; } }
    }
  
}
