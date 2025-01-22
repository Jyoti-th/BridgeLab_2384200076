using System;

class TriangleArea
{
    public void CalculateArea()
    {
        // Takes user Input in inches
        Console.Write("Enter the base of the triangle in inches: ");
        double baseInInches = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the triangle in inches: ");
        double heightInInches = Convert.ToDouble(Console.ReadLine());
        
        // Calculate area in square inches
        double areaInSquareInches = 0.5 * baseInInches * heightInInches;
        
        // Convert base and height to centimeters (1 inch = 2.54 cm)
        double baseInCm = baseInInches * 2.54;
        double heightInCm = heightInInches * 2.54;
        
        // Calculate area in square centimeters
        double areaInSquareCm = 0.5 * baseInCm * heightInCm;
		
		Console.WriteLine("The area of a triangle in square inches is " + areaInSquareInches + " and in square centimeters is " + areaInSquareCm);
        
    }

    public static void Main()
    {
        //Instance of the class
        TriangleArea obj = new TriangleArea();
        obj.CalculateArea();
    }
}
