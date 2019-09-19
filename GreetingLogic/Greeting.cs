using System;

namespace GreetingLogic
{
    public class Greeting
    {
        public string GetString()
        {
            var greeting = "Hello";
            int hour = DateTime.Now.Hour;

            if (hour<12)
            {
                greeting = "Good mornig";
            }
            else if (hour>18)
            {
                greeting = "Good evening";
            }

            return greeting;
        }
    }
}
