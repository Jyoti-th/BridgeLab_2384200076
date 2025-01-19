using System;
namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number1 = ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Number2 = ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Number3 = ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3;

            Console.WriteLine("The average of the numbers is: " + average);
        }
    }
}
