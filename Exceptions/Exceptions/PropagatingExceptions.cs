using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class PropagatingExceptions
    {
       
        // Method1: Throws an exception
        static void Method1()
        {
            throw new ArithmeticException("Attempted to divide by zero.");
        }

        // Method2: Calls Method1()
        static void Method2()
        {
            Method1();
        }

        // Main method: Calls Method2() and handles exception
        public static void Execute()
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Handled exception in Main: " + ex.Message);
            }
        }
    }

}

