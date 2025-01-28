using System;
public class ChocolateDistribution
{
	//Write the method to find the number of chocolates each child gets and number of remaining chocolates
	public static int[] FindRemainderAndQuotient(int divisor, int number) 
	{
		//number of chocolates each child gets
		int distributedChocolates = number / divisor;
		//number of remaining chocolates
		int remainingChocolates = number % divisor;
		
		//return the number of chocolates each child gets and number of remaining chocolates as an array
		return new int[] {distributedChocolates, remainingChocolates};
	}
	
	public static void Main(String[] args)
	{
		//user input for number of students and chocolates
		Console.Write("Enter the number of students : ");
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number of chocolates : ");
		int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
		//call the method
		int[] result = FindRemainderAndQuotient(numberOfStudents, numberOfChocolates);
		//Display the result
		Console.WriteLine("The number of chocolates each child gets is : " + result[0] + " and number of remaining chocolates is : " + result[1]);
		
	}
	
	

}