namespace IterativeTestability1
{
    public class HelperWrapper : IHelper
    {
        public string ToUpper(string input)
        {
            return Helper.ToUpper(input);
        }
    }
}
