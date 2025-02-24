using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public interface IIPAddressValidator
    {
        bool IsValidIPv4(string ip);
    }

    public class IPAddressValidator : IIPAddressValidator
    {
        public bool IsValidIPv4(string ip)
        {
            string pattern = @"^((25[0-5]|2[0-4][0-9]|1?[0-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1?[0-9]?[0-9])$";
            return Regex.IsMatch(ip, pattern);
        }
    }
}

