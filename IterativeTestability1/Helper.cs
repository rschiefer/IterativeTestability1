using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeTestability1
{
    public class Helper
    {
        public static string ToUpper(string input)
        {
            //bug
            input = null;
            return input.ToUpper();
        }

    }
}
