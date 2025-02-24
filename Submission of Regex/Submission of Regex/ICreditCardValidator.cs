using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    internal interface ICreditCardValidator
    {
        string ValidateCard(string cardNumber);
    }

    public class CreditCardValidator : ICreditCardValidator
    {
        public string ValidateCard(string cardNumber)
        {
            string visaPattern = @"^4[0-9]{15}$";
            string masterCardPattern = @"^5[0-9]{15}$";

            if (Regex.IsMatch(cardNumber, visaPattern))
                return "Valid Visa Card";
            else if (Regex.IsMatch(cardNumber, masterCardPattern))
                return "Valid MasterCard";
            else
                return "Invalid Card Number";
        }
    }
}

