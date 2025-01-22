using System;
class ConvertDistance
{
	//Method to Calculate Distance in kilometers to miles
	public void CalculateDistance()
	{
		//Taking user input in kilometers
		Console.Write("Enter the Distance in Kilometers = ");
		double km = Convert.ToDouble(Console.ReadLine());
		
		//Convert kilometers into Miles
		double miles = km / 1.6;
		
		//Display the Result
		Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km ");
	}
	public static void Main()
	{
		//Instance of class
		ConvertDistance obj = new ConvertDistance();
		//Calling method to Display the Result 
		obj.CalculateDistance();
		
	}
}