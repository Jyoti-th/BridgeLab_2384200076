using System;
public class Factors
{
	public static void Main()
	{
		Console.Write("Enter the number : ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		//Call the Find Factors metod and store them in an array
		int[] factors = FindTheFactors(number);
		//Display the result
		Console.Write("Factors of " + number + ": ");
		for(int i = 0; i < factors.Length; i++)
		{
			Console.Write(factors[i] + " ");
		}
		Console.WriteLine();
		
		//Display the sum of the factors
		Console.WriteLine("The sum of the factors of " + number + ": " + SumOfFactors(factors));
		
		//Display the product of the factors
		Console.WriteLine("The product of the factors of " + number + ": " + ProductOfFactors(factors));
		
		//Display the sum of square of the factors
		Console.WriteLine("The sum of square of the factors of " + number + ": " + FindSumOfSquare(factors));
		
	}
	
	
	// static Method to find the factors of the number
	public static int[] FindTheFactors(int num)
	{
		int count = 0;
		//first loop count the number of factors
		for(int i = 1; i <= num; i++)
		{
			if(num % i == 0)
			{
				count++;
			}
		}
		
		//Initialize the array with the count of factors
		int[] factors = new int[count];
		int index = 0;
		//second for loop to save the factors in array
		for(int i = 1; i <= num; i++)
		{
			if (num % i == 0)
			{
				factors[index++] = i;
			}
		}
		return factors;
	}
	
	//method to find the sum of the factors using factors array
	public static int SumOfFactors(int[] factors)
	{
		int sum = 0;
		foreach(int j in factors)
		{
			sum += j;
		}
		return sum;
	}
	
	//method to find the product of the factors using factors array
	public static long ProductOfFactors(int[] factors)
	{
		long product = 1;
		foreach(int factor in factors)
		{
			product *= factor;
		}
		return product;
	}
	
	//method to find the sum of square of the factors
	public static double FindSumOfSquare(int[] factors)
	{
		double sumOfSquare = 0;
		foreach(int factor in factors)
		{
			sumOfSquare += Math.Pow(factor, 2);
		}
		return sumOfSquare;
	}
}