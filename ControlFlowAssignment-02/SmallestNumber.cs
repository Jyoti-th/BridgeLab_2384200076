using System;
class SmallestNumber
{
	//Method to check smallest number among given three numbers
	public void CheckSmallestNumber()
	{
		//Input number 1, number2, and number 3 
		Console.Write("Enter the number Number 1 = ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number Number 2 = ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number Number 3 = ");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		//If-Statement to check number 1 is smallest of the three  numbers
		if((num1 < num2) && (num1 < num3))
		{
			//Number 1 is smallest
			Console.WriteLine("Is the first number the smallest? " + "Yes");
		}
		else
		{
			//Number 1 is not smallest
			Console.WriteLine("Is the first number the smallest? " + "No");
		}
	}
	 
	public static void Main()
	{
		//Instance of the class
		SmallestNumber obj = new SmallestNumber();
		//Call the method
		obj.CheckSmallestNumber();
	}
}