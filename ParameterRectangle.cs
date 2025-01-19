using System;
namespace ParameterRectangle
{
	public class program
	{
		static void Main(String[] args)
		{
			Console.Write("Enter the Length of rectangle = ");
			double length = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Enter the Width of Rectangle = ");
			double width = Convert.ToDouble(Console.ReadLine());
			
			double parameter = 2 * (length + width);
			
			Console.WriteLine("The Parameter of Rectangle is = " + parameter);
		}
	}
} 