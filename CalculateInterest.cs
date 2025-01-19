using System;
namespace CalculateInterest
{
public class program
{
static void Main(String[] args)
{
Console.Write("Enter the principal amount = ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the rate of interest = ");
double rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Time = ");
double time = Convert.ToDouble(Console.ReadLine());

double simpleInterest = (principal * rate * time) / 100;

Console.WriteLine("Simple Interest is = " + simpleInterest);
}
}
} 