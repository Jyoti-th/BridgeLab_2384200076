using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class HexColorValidator
    {
        public static bool IsValidHexColor(string color)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";
            return Regex.IsMatch(color, pattern);
        }
    }
}


