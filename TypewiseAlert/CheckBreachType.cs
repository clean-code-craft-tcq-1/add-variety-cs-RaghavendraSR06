using System;
using System.Reflection;
using static TypewiseAlert.BMSConstants;

namespace TypewiseAlert
{
    public class CheckBreachLevel
    {
        public static BreachType CheckBreachType(double value, double lowerLimit, double upperLimit)
        {
            if (value < lowerLimit)
            {
                return BreachType.TooLow;
            }
            if (value > upperLimit)
            {
                return BreachType.TooHigh;
            }
            return BreachType.Normal;
        }

        public static BreachType ClassifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
        {
            ICoolingType cooling = BMSInstanceCreator.GetInstance(coolingType.ToString()) as ICoolingType;
            return CheckBreachType(temperatureInC, cooling.LowerLimit, cooling.UpperLimit);         
        }      
    }
}
