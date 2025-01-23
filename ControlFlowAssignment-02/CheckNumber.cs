using System;
public class CheckNumber
{
	//Method to check number whether number is positive, negative or zero
	public void NumberIs()
	{
		//User Input
		Console.Write("Enter the number = ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		//number is positive
		if(number >= 0)
		{
			Console.WriteLine(number + " is positive.");
		}
		//number is negative
		else if(number < 0)
		{
			Console.WriteLine(number + " is negative.");
		}
		//number is zero
		else{
			Console.WriteLine(number + " is equal to zero.");
		}
		
	}
	public static void Main()
	{
		//Instance of the class
		CheckNumber obj = new CheckNumber();
		//Call the method
		obj.NumberIs();
		
	}
}