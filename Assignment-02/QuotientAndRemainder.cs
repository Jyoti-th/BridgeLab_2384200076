using System;
public class QuotientAndRemainder
{
	// Method to find the reminder and the quotient of a number 
	public static int[] FindRemainderAndQuotient(int number, int divisor)
	{
		int quotient = number / divisor;
		int remainder = number % divisor;
		//return quotient and remainder as an array 
		return new int[] {quotient, remainder};
	}
	
	public static void Main(String[] args)
	{
		//input the number and divisor
		Console.Write("Enter the number : ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the divisor : ");
		int divisor = Convert.ToInt32(Console.ReadLine());
		//call the method and get the result
		int[] result = FindRemainderAndQuotient(number, divisor);
		//Display the result 
		Console.WriteLine("The quotient is : " + result[0]);
		Console.WriteLine("The remainder is : " + result[1]);
	}
}