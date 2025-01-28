using System;

public class UnitConverter2
{
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

public class Program
{
    public static void Main()
    {
        // Yards to Feet
        Console.Write("Enter Yards: ");
        double yards = double.Parse(Console.ReadLine());
        double feetFromYards = UnitConverter2.ConvertYardsToFeet(yards);
        Console.WriteLine(yards + " yards = " + feetFromYards + " feet");

        // Feet to Yards
        Console.Write("Enter Feet: ");
        double feet = double.Parse(Console.ReadLine());
        double yardsFromFeet = UnitConverter2.ConvertFeetToYards(feet);
        Console.WriteLine(feet + " feet = " + yardsFromFeet + " yards");

        // Meters to Inches
        Console.Write("Enter Meters: ");
        double meters = double.Parse(Console.ReadLine());
        double inchesFromMeters = UnitConverter2.ConvertMetersToInches(meters);
        Console.WriteLine(meters + " meters = " + inchesFromMeters + " inches");

        // Inches to Meters
        Console.Write("Enter Inches: ");
        double inches = double.Parse(Console.ReadLine());
        double metersFromInches = UnitConverter2.ConvertInchesToMeters(inches);
        Console.WriteLine(inches + " inches = " + metersFromInches + " meters");

        // Inches to Centimeters
        Console.Write("Enter Inches: ");
        double inchesToConvert = double.Parse(Console.ReadLine());
        double cmFromInches = UnitConverter2.ConvertInchesToCentimeters(inchesToConvert);
        Console.WriteLine(inchesToConvert + " inches = " + cmFromInches + " centimeters");
    }
}
