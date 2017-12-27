namespace IterativeTestability1
{
    public class WorkClass
    {

        IHelper _helper;
        IDateProvider _dateProvider;
        public WorkClass(IHelper helper, IDateProvider dateProvider)
        {
            _helper = helper;
            _dateProvider = dateProvider;
        }
        public WorkClass() : this(new HelperWrapper(), new DateProvider())
        {

        }

        public string CreateGreeting(string name)
        {
            var upperName = _helper.ToUpper(name);
            var timeOfDay = "morning";
            if (_dateProvider.GetNow().Hour > 12)
            {
                timeOfDay = "afternoon";
            }
            if (_dateProvider.GetNow().Hour > 17)
            {
                timeOfDay = "evening";
            }
            return string.Format("Good {0}, {1}.", timeOfDay, upperName);
        }
    }
}
