using System;

namespace TypewiseAlert
{
    class EmailAlert : IAlerter
    {
        public bool IsNotified = false;
        public void Alert(BMSConstants.BreachType breachType)
        {
            const ushort header = 0xfeed;
            Console.WriteLine($"{header}{breachType}");
            IsNotified = true;
        }

    }
}
