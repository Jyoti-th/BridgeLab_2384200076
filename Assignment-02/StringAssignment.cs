using System;
using System.Linq; // Required for Count()

namespace StringAssignment
{
    class CountVowelAndConsonant
    {
        public void Count()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine() ?? ""; // Use null-coalescing to prevent null issues

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            string vowels = "AEIOUaeiou";
            int vowelCount = str.Where(c => vowels.Contains(c)).Count(); // Count vowels
            int consonantCount = str.Where(char.IsLetter).Count() - vowelCount; // Count consonants

            // Display output using string concatenation
            Console.WriteLine("Total vowels in \"" + str + "\" is " + vowelCount + " and consonants is " + consonantCount);
        }
    }

    class Program
    {
        static void Main()
        {
            CountVowelAndConsonant obj = new CountVowelAndConsonant();
            obj.Count();
        }
    }
}
