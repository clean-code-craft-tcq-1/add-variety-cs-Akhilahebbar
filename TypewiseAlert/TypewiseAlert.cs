using System;
using static TypewiseAlert.Constants;

namespace TypewiseAlert
{
    public class TypewiseAlert
    {   
        public static void CheckAndAlert(AlertTarget alertTarget, BatteryCharacter batteryChar, double tempVal)
        {
            BreachType breachType =ClassifyTemperatureBreach(batteryChar.coolingType, tempVal);
            IAlerter source = InstanceFactory.GetInstance(alertTarget.ToString()) as IAlerter;
            source.AlertBreachType(breachType);
        }

        public static BreachType ClassifyTemperatureBreach(CoolingType coolingType, double tempVal)
        {
            ICoolingType cooling = InstanceFactory.GetInstance(coolingType.ToString()) as ICoolingType;
            return InferBreachLevel(tempVal, cooling.LowerLimit, cooling.UpperLimit);

        }

        public static BreachType InferBreachLevel(double value, double lowerLimit, double upperLimit)
        {
            if (value < lowerLimit)
            {
                return BreachType.TOO_LOW;
            }
            if (value > upperLimit)
            {
                return BreachType.TOO_HIGH;
            }
            return BreachType.NORMAL;
        }
    }
}
