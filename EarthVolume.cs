using System;
class EarthVolume
{
	double radius = 6378;
	
	//Method to calculate Volume of earth in cubic kilometers and Miles
	public void VolumeOfEarth()
	{
		//Volume of earth in Kilometers
		double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
		//Convert radius in to miles
		double radiusInMiles = radius * 0.621371;
		//Volume of earth in miles
		double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusInMiles, 3);
		
		//Display the Result
		Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm3 + " and cubic miles is " + volumeMiles);
	}
	
	public static void Main()
	{
		//Instance of Class
		EarthVolume obj = new EarthVolume();
		//Calling the Method to Display the Result
		obj.VolumeOfEarth();
	}
}
