using System;
public class NaturalNumber
{
	public static void Main()
	{
		//User Input to take the number
		Console.Write("Enter the number : ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		if(number < 0)
		{
			Console.WriteLine("Please Provide the Positive Integer : ");
		}
		else
		{
			int sum1 = SumOfNatural(number);//result from method 1
			int sum2 = FindSum(number);//result from method 2
			//Compare the both sum and Display the result
			if(sum1 == sum2)
			{
				Console.WriteLine("The Sum of given N natural numbers is : " + sum1);
			}
		}
	}
	
	//Method to find the sum of n natural numbers using recursion
	public static int SumOfNatural(int num)
	{
	//Base Class
		if(num == 1)
		{
			return 1;
		}
		else
		{
			return num + SumOfNatural(num-1);
		}
	}
	//Method to find the sum of n natural numbers using the formulae  n*(n+1)/2 
	public static int FindSum(int num)
	{
		return (num*(num+1))/2;
	}

	
}