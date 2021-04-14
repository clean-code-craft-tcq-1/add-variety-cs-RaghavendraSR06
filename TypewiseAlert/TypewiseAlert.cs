using System;
using static TypewiseAlert.BMSConstants;

namespace TypewiseAlert
{
    public class BMSTypeAlert
    {
        public  IAlerter AlertSource;

        public BMSTypeAlert(string alertTarget)
        {
            AlertSource = BMSInstanceCreator.GetInstance(alertTarget) as IAlerter;
        }

        public void CheckAndAlert(Battery batteryChar, double temperature)
        {
            BreachType breachType = CheckBreachLevel.ClassifyTemperatureBreach(batteryChar.CoolingType, temperature);
            AlertSource.Alert(breachType);
        }
    }
}
