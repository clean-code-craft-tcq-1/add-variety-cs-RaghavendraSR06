using System;

namespace TypewiseAlert
{
   public class ConsoleAlert : IAlerter
    {
       
        public void Alert(BMSConstants.BreachType breachType)
        {
            Console.WriteLine($"Hi, the temperature is {breachType}\n");
            
        }
    }
}
