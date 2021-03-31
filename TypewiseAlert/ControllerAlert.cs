using System;
using static TypewiseAlert.BMSConstants;

namespace TypewiseAlert
{
    class ControllerAlert : IAlerter
    {
        public void Alert(BMSConstants.BreachType breachType)
        {
            string recepient = "a.b@c.com";
            DisplayBreachStatus(breachType, recepient);
        }

        public void DisplayBreachStatus(BreachType breachType, string recepient)
        {
            Console.WriteLine("To: {}\n", recepient);
            Console.WriteLine($"Hi, the temperature is {breachType}\n");
        }
    }
}
