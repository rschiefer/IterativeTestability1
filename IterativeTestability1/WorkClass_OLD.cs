using System;

namespace IterativeTestability1
{
    public class WorkClass_OLD
    {
        public string CreateGreeting(string name)
        {
            var upperName = Helper.ToUpper(name);
            var timeOfDay = "morning";
            if (DateTime.Now.Hour > 12)
            {
                timeOfDay = "afternoon";
            }
            if (DateTime.Now.Hour > 17)
            {
                timeOfDay = "evening";
            }
            return string.Format("Good {0}, {1}.", timeOfDay, upperName);
        }
    }
}
