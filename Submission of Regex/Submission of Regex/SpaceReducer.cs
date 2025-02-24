using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class SpaceReducer
    {
        public static string RemoveExtraSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }

    }
}
