using System;
public class Table
{
	//declare an array to store multiplication result
	static int[] multiplication = new int[10];
	public static void Main()
	{
		MultiplicationTable();
	}
	//Method to print a multiplication table of a number.
	public static void MultiplicationTable()
	{
		Console.Write("Enter the number = ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		//Calculate and display the table for particular number
		for(int i = 1; i <= 10; i++)
		{
		
			multiplication[i-1] = num * i ;
			Console.WriteLine(num + " x " + i + " = " + (multiplication[i-1]));
		}
	}

}