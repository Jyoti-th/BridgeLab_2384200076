using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NestedTryCatch
    {

        public static void eEsted()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                // Taking user input for index
                Console.Write("Enter array index: ");
                int index = Convert.ToInt32(Console.ReadLine());

                try
                {
                    // Accessing element at given index
                    int value = numbers[index];

                    // Taking user input for divisor
                    Console.Write("Enter divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    // Performing division
                    int result = value / divisor;
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
        }
    
}
}
