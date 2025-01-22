using System;
class BasicCalculator
{	
//Method to perform calculation(addition,subtraction,multiplication and division)
	public void PerformCalculation()
	{
		//Takes user input(floating numbers)
		Console.Write("Enter the Number1 = ");
	    float Num1 = Convert.ToSingle(Console.ReadLine());
	    Console.Write("Enter the Number2 = ");
	    float Num2 = Convert.ToSingle(Console.ReadLine());
		
		//Operations
		float addition = (Num1 + Num2);
		float subtraction = (Num1 - Num2);
		float multiplication = (Num1 * Num2);
		float division = (Num1 / Num2);
		
		//Display the result 
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + 
            Num1 + " and " + Num2 + " is " + addition + ", " + subtraction + ", " + multiplication + ", and " + division.ToString("0.00"));
	}
	public static void Main()
	{
		//Instance of class
		BasicCalculator obj = new BasicCalculator();
		//Calling the method
		obj.PerformCalculation();
	}
}