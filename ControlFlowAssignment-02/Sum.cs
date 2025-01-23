using System;
public class Sum
{
	//Method to calculate Sum
	public void SumOfNumbers()
	{
		double total = 0.0;
		double value;
		//Ask for user input until user enters 0 
		do{
		Console.Write("Enter the value = ");
		value = Convert.ToDouble(Console.ReadLine());
		total += value;
		}
		while(value != 0);
		//Print Sum of number user entered before 0 
		Console.WriteLine("The Sum of numbers is : " + total);
		
	}
	public static void Main()
	{
		//Instance of the class
		Sum obj = new Sum();
		//Call the method
		obj.SumOfNumbers();
		
	}
}