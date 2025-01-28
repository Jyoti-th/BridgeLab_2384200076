using System;
public class CheckNumber
{
	//Method  to check whether a number is positive, negative, or zero.

	public static int NumberIs(int number)
	{
		//number is negative
		if(number < 0)
		{
			return -1;
		}
		//Number is positive
		else if(number > 0)
		{
			return 1;
		}
		//number is zero
		else{
			return 0;
		}
	}
	
	public static void Main(String[] args)
	{
		//take number as a input from user
		Console.Write("Enter the number you want to check : " );
		int number = Convert.ToInt32(Console.ReadLine());
		//Call the method directly
		Console.WriteLine(NumberIs(number));
	}
}