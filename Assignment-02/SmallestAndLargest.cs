using System;
class SmallestAndLargest
{
	//Method to find the smallest and the largest of the 3 numbers.
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
	{
		int smallest = number1;
		int largest = number1;
		
		if(number2 < smallest)
		{
			smallest = number2;
		}
		if(number3 < smallest)
		{
			smallest = number3;
		}
		
		if(number2 > largest)
		{
			largest = number2;
		}
		if(number3 > largest)
		{
			largest = number3;
		}
		
		//return smallest and largest number as an array 
		return new int[] {smallest, largest};
	}
	
	public static void Main()
	{
		//user input for three numbers	
		Console.Write("Enter the number 1 : ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number 2 : " );
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number 3 : " );
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		//Call the method and get the result
		int[] result = FindSmallestAndLargest(number1, number2, number3);
		Console.WriteLine("The smallest number is : " + result[0]);
		Console.WriteLine("The largest number is : " + result[1]);
	}
}