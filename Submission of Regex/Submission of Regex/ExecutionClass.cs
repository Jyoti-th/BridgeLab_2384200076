using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Regex
{
    public class ExecutionClass
    {
        public void CallingUsernameValidator()
        {
            string[] testUsernames = { "user_123", "123user", "us", "Valid_Name", "A_long_username123" };

            foreach (string username in testUsernames)
            {
                Console.WriteLine($"{username} → {(UsernameValidator.IsValidUsername(username) ? "Valid" : "Invalid")}");
            }
        }

        public void CallingLicensePlateValidator()
        {
            string[] testPlates = { "AB1234", "A12345", "XY9876", "ab1234", "XYZ123" };

            foreach (string plate in testPlates)
            {
                Console.WriteLine($"{plate} → {(LicensePlateValidator.IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
            }
        }

        public void CallingHexColorValidator()
        {
            string[] testColors = { "#FFA500", "#ff4500", "#123", "#abcdef", "#GGGGGG" };

            foreach (string color in testColors)
            {
                Console.WriteLine($"{color} → {(HexColorValidator.IsValidHexColor(color) ? "Valid" : "Invalid")}");
            }
        }

        public void CallingEmailExtractor()
        {
            string inputText = "Contact us at support@example.com and info@company.org for more details.";
            EmailExtractor.ExtractEmails(inputText);
        }

        public void CallingCapitalizedWordExtractor()
        {
            string inputText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            CapitalizedWordExtractor.ExtractCapitalizedWords(inputText);
        }

        public void CallingDateExtractor()
        {
            string inputText = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            DateExtractor.ExtractDates(inputText);
        }

        public void CallingLinkExtractor()
        {
            string inputText = "Visit https://www.google.com and http://example.org for more info.";
            LinkExtractor.ExtractLinks(inputText);
        }

        public void CallingSpaceReducer()
        {
            string text = "This  is   an example    with   multiple spaces.";
            string result = SpaceReducer.RemoveExtraSpaces(text);
            Console.WriteLine(result);
        }

        public void CallingCensorBadWords()
        {
            string input = "This is a damn bad example with some stupid words.";
            string[] badWords = { "damn", "stupid" };  // Bad words list

            string result = CensorBadWords.CensorText(input, badWords);
            Console.WriteLine(result);
        }

        public void CallingIPAddressValidator()
        {
            IIPAddressValidator validator = new IPAddressValidator(); // Interface ka object class se create hoga

            string[] testIPs = { "192.168.1.1", "255.255.255.255", "256.100.50.25", "1.1.1.01", "192.168.0.300" };

            foreach (string ip in testIPs)
            {
                Console.WriteLine($"{ip} → {(validator.IsValidIPv4(ip) ? "Valid" : "Invalid")}");
            }
        }

        public void CallingCreditCardValidator()
        {
            ICreditCardValidator validator = new CreditCardValidator();

            string[] testCards = { "4111111111111111", "5123456789012345", "378282246310005", "6011000990139424", "4234567890123456" };

            foreach (string card in testCards)
            {
                Console.WriteLine($"{card} → {validator.ValidateCard(card)}");
            }
        }

        public void CallingProgrammingLanguageExtractor()
        {
            string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            ProgrammingLanguageExtractor.ExtractLanguages(input);
        }

        public void CallingCurrencyExtractor()
        {
            string input = "The price is $45.99, and the discount is $ 10.50.";
            CurrencyExtractor.ExtractCurrency(input);

        }

        public void CallingRepeatingWordFinder()
        {
            string input = "This is is a repeated repeated word test.";
            RepeatingWordFinder.FindRepeatingWords(input);
        }

        public void CallingSSNValidator()
        {
            string[] testSSNs = { "123-45-6789", "123456789", "000-12-3456", "987-65-4321" };

            foreach (string ssn in testSSNs)
            {
                Console.WriteLine($"{ssn} → {(SSNValidator.IsValidSSN(ssn) ? "Valid" : "Invalid")}");
            }
        }
    }

}

