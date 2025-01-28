using System;
class NaturalNumber
{
	//static method to calculate the sum of n natural number
	public static int SumOfNaturalNumber(int n)
	{
		int sum = 0;
		//for loop to calculate sum and return the value
		for(int i = 1; i <= n; i++)
		{
			//sum variable to store
			sum = sum+i;
		}
		return sum;
	}
	
	public static void Main()
	{
		Console.Write("Enter the value of N (limit) : ");
		int n = Convert.ToInt32(Console.ReadLine());
		//Call the method and display the result
		Console.WriteLine("The sum of " + n + " natural number is : " + SumOfNaturalNumber(n));
	}
}