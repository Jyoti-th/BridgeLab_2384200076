using System;
public class  WindchillTemperature
{
	public double CalculateWindChill(double temperature, double windSpeed)
	{
		double windchill = 35.74 + 0.6215 * temperature + (0.4275*temperature - 35.75) * Math.Pow(windSpeed, 0.16);
		return windchill;
	}
	
	public static void Main()
	{
		Console.Write("Enter the Temperature : ");
		double temp = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the WindSpeed : ");
		double windSpeed = Convert.ToInt32(Console.ReadLine());
		//An Instance of the class
		WindchillTemperature obj = new WindchillTemperature();
		//Display the rresult
		Console.WriteLine("The Wind Chill temperature is : " + obj.CalculateWindChill(temp, windSpeed));
	}
}