using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutionClass obj = new ExecutionClass();
            Console.WriteLine("Enter the option number (1-15):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: obj.CallingUsernameValidator(); break;
                case 2: obj.CallingLicensePlateValidator(); break;
                case 3: obj.CallingHexColorValidator(); break;
                case 4: obj.CallingEmailExtractor(); break;
                case 5: obj.CallingCapitalizedWordExtractor(); break;
                case 6: obj.CallingDateExtractor(); break;
                case 7: obj.CallingLinkExtractor(); break;
                case 8: obj.CallingSpaceReducer(); break;
                case 9: obj.CallingCensorBadWords(); break;
                case 10: obj.CallingIPAddressValidator(); break;
                case 11: obj.CallingCreditCardValidator(); break;
                case 12: obj.CallingProgrammingLanguageExtractor(); break;
                case 13: obj.CallingCurrencyExtractor(); break;
                case 14: obj.CallingRepeatingWordFinder(); break;
                case 15: obj.CallingSSNValidator(); break;
                default: Console.WriteLine("Invalid choice. Please enter a number between 1 and 15."); break;
            }
        }
    }
}
