namespace TypewiseAlert
{
    public class BMSConstants
    {
        public enum BreachType
        {
            Normal,
            TooLow,
            TooHigh
        };

        public struct BatteryCharacter
        {
            public CoolingType coolingType;           
        }

        public enum CoolingType
        {
            PassiveCooling,
            HiActiveCooling,
            MedActiveCooling
        };

        public enum AlertTarget
        {
            ToController,
            ToEmail
        };
    }
}
