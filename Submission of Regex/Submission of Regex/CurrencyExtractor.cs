using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class CurrencyExtractor
    {
        public static void ExtractCurrency(string text)
        {
            string pattern = @"(?<=\$)\s*\d+\.\d{2}";
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Extracted Currency Values:");
            foreach (Match match in matches)
            {
                Console.WriteLine($"${match.Value.Trim()}");
            }
        }

    }
}
