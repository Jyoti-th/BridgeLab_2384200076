using System;

namespace KiloToMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance = ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            double miles = kilometers * 0.621371;

            Console.WriteLine("The distance in miles is: " + miles);
        }
    }
}
