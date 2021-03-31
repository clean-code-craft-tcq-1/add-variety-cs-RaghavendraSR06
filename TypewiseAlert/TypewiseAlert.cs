using System;
using static TypewiseAlert.BMSConstants;

namespace TypewiseAlert
{
    public class BMSTypeAlert
    {   
        public static void CheckAndAlert(AlertTarget alertTarget, BatteryCharacter batteryChar, double temperature)
        {
            BreachType breachType = CheckBreachLevel.ClassifyTemperatureBreach(batteryChar.coolingType, temperature);
            IAlerter source = BMSInstanceCreator.GetInstance(alertTarget.ToString()) as IAlerter;
            source.Alert(breachType);
        }
    }
}
