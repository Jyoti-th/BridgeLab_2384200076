using System;
class HeightConverter
{
	double oneInch = 2.54; // one inch = 2.54 centimeters
	double oneFeet = 12; // one feet = 12 inches
	
	//Method to Calculate Height from Centimeters to feet and inch
	public void CalculateHeight()
	{
		//Take user input height in centimeters
		Console.Write("Enter the height in centimeters = ") ;
		double height = Convert.ToDouble(Console.ReadLine());
		
		//Converts height into feet
		double feet = (height/oneInch) / oneFeet;
		
		//Converts height into inches
		double inch = height / oneInch;
		
		//Display the result 
		Console.WriteLine("Your Height in cm is " + " height while in feet is " + feet.ToString("0.00") + " and inches is " + inch.ToString("0.00"));
	}
	public static void Main()
	{
		//Instance of class
		HeightConverter obj = new HeightConverter();
		//Calling the method to display the result
		obj.CalculateHeight();
	}
}