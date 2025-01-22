using System;
class KilometersToMiles
{
	//distance in kilometers
	double distanceInKm = 10.8;
	
	//Method to convert distance in miles
	public double ConvertDistance()
	{
		//calculating distance in miles
		double miles = distanceInKm * 0.6;
		return miles;
	}
	
	public static void Main()
	{
		//Instance of class
		KilometersToMiles obj = new KilometersToMiles();
		//Display the conversion of distance in miles
		Console.WriteLine("The distance " + obj.distanceInKm + " km in miles is " + obj.ConvertDistance());
}
}