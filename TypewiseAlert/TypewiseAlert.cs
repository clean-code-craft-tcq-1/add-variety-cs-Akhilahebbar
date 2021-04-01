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
            return InferBreachLevel(tempVal, cooling.LimitLow, cooling.LimitHigh);

        }

         public static BreachType InferBreachLevel(double value, double lowerLimit, double upperLimit)
        {
           return (value >= lowerLimit && value <= upperLimit)?BreachType.NORMAL: CheckBreachLow(value, lowerLimit, upperLimit);
        }
        public static BreachType CheckBreachLow(double value, double lowerLimit,double upperLimit)
        {
            return value < lowerLimit ? BreachType.TOO_LOW : BreachType.TOO_HIGH;
         
        }
    }
}
