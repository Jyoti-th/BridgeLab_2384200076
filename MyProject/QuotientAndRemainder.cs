using System;
class QuotientAndRemainder
{
	public void CalculateOperation()
	{
		//Taking input from the user(number 1 and number 2)
		Console.Write("Enter the Number 1 = ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the Number 2 = ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		//perform quotient operation
		int quotient = (num1 / num2);
		
		//perform remainder operation
		int remainder = (num1 % num2);
		//Display the Result 
		Console.WriteLine("The Quotient is "+ quotient + " and Remainder is " + remainder + " of two numbers " + num1+ " and "+ num2);

		
		
	}
	public static void Main()
	{
		//Instance of class
		QuotientAndRemainder obj = new QuotientAndRemainder();
		//Calling the method
		obj.CalculateOperation();
		
	}
}