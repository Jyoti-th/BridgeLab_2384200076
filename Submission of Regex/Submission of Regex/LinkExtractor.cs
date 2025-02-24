using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class LinkExtractor
    {
        public static void ExtractLinks(string text)
        {
            string pattern = @"\bhttps?://(www\.)?\S+\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }

}
