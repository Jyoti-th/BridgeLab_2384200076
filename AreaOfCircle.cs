using System;
namespace AreaOfCircle
{
	public class program
	{
		static void Main(String[] args)
		{
			Console.Write("Enter the Radius = ");
			double radius = Convert.ToDouble(Console.ReadLine());
			double pi = 3.14159265359;
			double Area = pi * radius * radius;
			Console.WriteLine("The area of circle is = " + Area);
			}
		}
}