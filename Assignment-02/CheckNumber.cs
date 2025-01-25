using System;
public class CheckNumber
{
	//declare static variable so both method can access it
	static int[] numbers = new int[5];
	public static void Main()
	{
		Console.WriteLine("Enter 5 Numbers");
		//Call the method to perform operation
		CheckNumbers();
		Compare();
		
	}
	//Method to  check whether a number is positive,  negative, or zero.
	public static void CheckNumbers()
	{
		for(int i = 0; i < numbers.Length; i++)
		{
			Console.Write("Enter number " + (i+1) +":");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
			
			//check number is positive
			if (numbers[i] > 0)
			{
				//number is positive so check for even and odd
				if(numbers[i] % 2 == 0)
				{
					Console.WriteLine(numbers[i] + " is Even number.");
				}
				else{
					Console.WriteLine(numbers[i] + " is Odd number.");
				}
			}
			// if condition is false then check else if for negative numbers
			else if (numbers[i] < 0)
			{
				Console.WriteLine(numbers[i] + " is Negative number.");
			}
			//number is zero
			else{
				Console.WriteLine(numbers[i] + " is zero.");
			}
		}
	}	
	
	//Method to compare first and last element of the array
	public static void Compare()
	{
		if(numbers[0] > numbers[4])
		{
			Console.WriteLine(numbers[0] + " is greater then " + numbers[4]);
		}
		else if(numbers[0] < numbers[4])
		{
			Console.WriteLine(numbers[0] + " is less then " + numbers[4]);
		}
		else{
			Console.WriteLine(numbers[0] + " is equal to " + numbers[4]);
		}
			
	}
}