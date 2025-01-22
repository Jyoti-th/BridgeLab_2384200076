using System;

class DistanceYards
{
    public void ConvertDistance()
    {
        // Take input the distance in feet
        Console.Write("Enter the distance in feet = ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert feet to yards (1 yard = 3 feet)
        double distanceInYards = distanceInFeet / 3;

        // Convert feet to miles (1 mile = 1760 yards)
        double distanceInMiles = distanceInYards / 1760;

        // Display the result
        Console.WriteLine("The distance in yards is " + distanceInYards.ToString("0.00") + " and in miles is " + distanceInMiles.ToString("0.00"));
    }

    public static void Main()
    {
        //Instance of the class 
        DistanceYards obj = new DistanceYards();
		//Calling the method
        obj.ConvertDistance();
    }
}
