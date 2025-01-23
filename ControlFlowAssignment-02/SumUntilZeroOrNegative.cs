using System;
public class SumUntilZeroOrNegative
{
	//Method to calculate Sum
	public void SumOfNumbers()
	{
		double total = 0.0;
		double value;
		//Ask for user input until user enters 0 using while loop
		while(true)
		{
		Console.Write("Enter the value = ");
		value = Convert.ToDouble(Console.ReadLine());
		
		if(value <= 0)
		{
			break;
		}
		total += value;
	    }
	
		//Print Sum of number user entered before 0 
		Console.WriteLine("The Sum of numbers is : " + total);
		
	}
	public static void Main()
	{
		//Instance of the class
		SumUntilZeroOrNegative obj = new SumUntilZeroOrNegative();
		//Call the method
		obj.SumOfNumbers();
		
	}
}