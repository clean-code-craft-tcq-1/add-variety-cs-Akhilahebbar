using System;
using static TypewiseAlert.Constants;

namespace TypewiseAlert
{
    class ControllerAlerter : IAlerter
    {
        public void AlertBreachType(Constants.BreachType breachType)
        {
            string recepient = "a.b@c.com";
            Console.WriteLine("To: {}\n", recepient);
            Console.WriteLine($"Hi, the temperature is {breachType}\n");
        }

    }
    class MailAlerter : IAlerter
    {
        public void AlertBreachType(Constants.BreachType breachType)
        {
           string Message = "The temperature is ";
            Console.WriteLine("{} : {}\n", Message + breachType);
        }
    }
}
