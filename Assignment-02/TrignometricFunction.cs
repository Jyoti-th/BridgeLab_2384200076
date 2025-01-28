using System;
public class TrignometricFunction
{
	
    // Method to calculate various trigonometric functions
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = Math.PI * angle / 180;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return results as an array
        return new double[] { sine, cosine, tangent };
    }

    public static void Main()
    {
        // Take user input for angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine("Sine of {angle} degrees: " + results[0]);
        Console.WriteLine("Cosine of {angle} degrees: " + results[1]);
        Console.WriteLine("Tangent of {angle} degrees: " + results[2]);
    }
}

