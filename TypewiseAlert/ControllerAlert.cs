using System;
using static TypewiseAlert.BMSConstants;

namespace TypewiseAlert
{
    class ControllerAlert : IAlerter
    {
       
        public void Alert(BreachType breachType)
        {
            string recepient = "a.b@c.com";
            DisplayBreachStatus(breachType, recepient);
        }

        public void DisplayBreachStatus(BreachType breachType, string recepient)
        {
            Console.WriteLine($"To: {recepient}\n");
            Console.WriteLine($"Hi, the temperature is {breachType}\n");
        }
    }
}
