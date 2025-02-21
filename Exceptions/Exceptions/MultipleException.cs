using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MultipleException
    {
    
        public static void HandlingMultipleException()
        {
            try
            {
                // Declaring an array 
                int[] numbers = { 10, 20, 30, 40, 50 };

                // Taking index input
                Console.Write("Enter an index: ");
                int index = Convert.ToInt32(Console.ReadLine());

                // Printing value at given index
                Console.WriteLine($"Value at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }
    }

}

