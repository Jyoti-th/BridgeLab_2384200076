using System;
namespace Temperature
{
	public class program
	{
		static void Main(String[] args)
		{
			Console.Write("Enter the temperature in celsius = ");
			double celsius = Convert.ToDouble(Console.ReadLine());
			
			double farhenheit = (celsius * 9/5) + 32;
			Console.WriteLine("The Temperature is " + farhenheit);
		}
	}
}

