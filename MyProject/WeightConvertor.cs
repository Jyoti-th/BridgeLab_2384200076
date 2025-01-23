using System;

class WeightConverter
{
	public void PoundsToKilograms()
	{
		// Take user input for weight in pounds
        Console.Write("Enter the weight (in pounds): ");
        double pounds = Convert.ToDouble(Console.ReadLine());
		
		// Convert pounds to kilograms using formula(1 pound = 0.453592 kilograms)
        double weightInKg = pounds* 0.453592;
		//Print the Result
		 Console.WriteLine("The weight of the person in pounds is " + pounds +" and in kg is " + weightInKg);
	}
    public static void Main(string[] args)
    {
    // Instance of class
	WeightConverter obj = new WeightConverter();
	//Call the method
	obj.PoundsToKilograms();
    }
}
