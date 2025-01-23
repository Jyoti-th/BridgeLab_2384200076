using System;

class DoubleOperation
{
    // Method to perform and display double operations
    static void PerformOperations(double a, double b, double c)
    {
        // Compute the double operations
        double result1 = a + b * c;   // Multiplication (*) has higher precedence than addition (+)
        double result2 = a * b + c;   // Multiplication (*) has higher precedence than addition (+)
        double result3 = c + a / b;   // Division (/) has higher precedence than addition (+)
        double result4 = a % b + c;   // Modulus (%) has higher precedence than addition (+)

        // Print the results
        Console.WriteLine("The results of Double Operations are:");
        Console.WriteLine($"1. a + b * c = {result1}");
        Console.WriteLine($"2. a * b + c = {result2}");
        Console.WriteLine($"3. c + a / b = {result3}");
        Console.WriteLine($"4. a % b + c = {result4}");
    }

    static void Main(string[] args)
    {
        // Take user input for a, b, and c
         Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Call the method to perform operations
        PerformOperations(a, b, c);
    }
}
