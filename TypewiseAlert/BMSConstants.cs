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
        
        public enum CoolingType
        {
            PassiveCooling,
            HiActiveCooling,
            MedActiveCooling
        };

        public enum AlertTarget
        {
            ControllerAlert,
            EmailAlert,
            ConsoleAlert
        };
    }
}
