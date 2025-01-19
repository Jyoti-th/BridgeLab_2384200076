using System;
namespace CylinderVolume
{
	public class program
	{
		static void Main(String[] args)
		{
			Console.Write("Enter the radius of cylinder = ");
			double radius = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Enter the height of cylinder = ");
			double height = Convert.ToDouble(Console.ReadLine());
			
			double volume = Math.PI * Math.Pow(radius, 2) * height;
			
			Console.WriteLine("The volume of cylinder is = " + volume);
		}
	}
}