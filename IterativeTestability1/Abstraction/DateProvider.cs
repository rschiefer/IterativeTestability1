using System;

namespace IterativeTestability1
{
    public class DateProvider : IDateProvider
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}
