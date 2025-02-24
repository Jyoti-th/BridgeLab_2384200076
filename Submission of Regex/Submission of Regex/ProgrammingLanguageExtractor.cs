using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class ProgrammingLanguageExtractor
    {
        public static void ExtractLanguages(string text)
        {
            string pattern = @"\b(Java|Python|JavaScript|C\+\+|C#|Go|Swift|Ruby|Kotlin|PHP|Rust|TypeScript)\b";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine("Extracted Programming Languages:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
