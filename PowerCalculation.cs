using System;

namespace PowerCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the base: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(num, exponent);

            Console.WriteLine("The result is " + result);
        }
    }
}
