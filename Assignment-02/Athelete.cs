using System;
public class Athelete
{
	//Method to calculate how many rounds must the athlete complete

	 public static void CalculateRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3; // Calculate perimeter
            double distance = 5000; // Total distance in meters (5 km)
            double rounds = Math.Ceiling(distance / perimeter); // Calculate and round up the number of rounds
            
            Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km.");
        }
		
		public static void Main(String[] args)
		{
			//User input to take three side of park
			Console.Write("Enter the first side of the triangular park (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the second side of the triangular park (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the third side of the triangular park (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());
			//Call the static method directly
			CalculateRounds(side1, side2, side3);
		}
}