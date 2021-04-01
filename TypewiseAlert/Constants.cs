namespace TypewiseAlert
{
    public class Constants
    {
        public enum CoolingType
        {
            ActiveHiCooling,
            ActivePassiveCooling,
            ActiveMedCooling
        };
        public enum BreachType
        {
            NORMAL,
            TOO_LOW,
            TOO_HIGH
        };
        public enum AlertTarget
        {
            TO_CONTROLLER,
            TO_EMAIL
        };
        public struct BatteryCharacter
        {
            public CoolingType coolingType;
            public string brand;
        }

    }
}
