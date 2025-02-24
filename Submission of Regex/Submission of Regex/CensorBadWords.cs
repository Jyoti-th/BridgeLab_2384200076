using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class CensorBadWords
    {
        public static string CensorText(string text, string[] badWords)
        {
            foreach (string word in badWords)
            {
                string pattern = @"\b" + Regex.Escape(word) + @"\b";  // Exact word match karega
                text = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
            }
            return text;
        }

    }
}
