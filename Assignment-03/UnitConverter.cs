using System;
public class UnitConverter
{
    public static void Main()
	{
		Console.WriteLine("Enter the unit in kilometers : ");
		double km = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the unit in miles : ");
		double miles = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the unit in meters : ");
		double meters = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the unit in feet : ");
		double feet = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("After the unit conversion results are : ");
		Console.WriteLine("Kilometers to Miles = " + KmToMiles(km));
		Console.WriteLine("Miles to Kilometers = " + MilesToKm(miles));
		Console.WriteLine("Meters To Feet = " + MetersToFeet(meters));
		Console.WriteLine("Feet To Meters = " + FeetToMeters(feet));

		
		
	}
	
	//Method to convert kilometers to miles
	public static double KmToMiles(double km)
	{
		double km2miles = 0.621371;
		return km * km2miles;
	}
	
	//Method to convert miles to kilometers
	public static double MilesToKm(double miles)
	{
		double miles2km = 1.60934;
		return miles * miles2km;
	}
	
	//Method to convert meters to feet
	public static double MetersToFeet(double meters)
	{
		double meters2feet = 3.28084;
		return meters * meters2feet;
	}
	
	//Method to create feet to meters
		public static double FeetToMeters(double feet)
	{
		double feet2meters = 0.3048;
		return feet * feet2meters;
	}
}
