using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class RepeatingWordFinder
    {
        public static void FindRepeatingWords(string text)
        {
            string pattern = @"\b(\w+)\s+\1\b";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine("Repeating Words:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}
