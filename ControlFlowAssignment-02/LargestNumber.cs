using System;
class LargestNumber
{
	//Method to check smallest number among given three numbers
	public void CheckLargestNumber()
	{
		//Input number 1, number2, and number 3 
		Console.Write("Enter the number Number 1 = ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number Number 2 = ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the number Number 3 = ");
		int num3 = Convert.ToInt32(Console.ReadLine());
		
		//If-Statement to check number 1 is smallest of the three  numbers
		if((num1 > num2) && (num1 > num3))
		{
			//Number 1 is largest
			Console.WriteLine("Is the first number the largest? " + "Yes");
			Console.WriteLine("Is the first second the largest? " + "No");
			Console.WriteLine("Is the third number the largest? " + "No");
			
		}
		else if((num2 > num1) && (num2 > num3))
		{
			//Number 2 is largest
			Console.WriteLine("Is the first number the largest? " + "No");
			Console.WriteLine("Is the second number the largest? " + "Yes");
		    Console.WriteLine("Is the  third number the largest? " + "No");
		}
		else if((num3 > num1) && (num3 > num2))
		{
			//Number 3 is largest
			Console.WriteLine("Is the first number the largest? " + "No");
			Console.WriteLine("Is the second number the largest? " + "No");
		    Console.WriteLine("Is the  third number the largest? " + "Yes");
		}
		else
		{
			//When all the numbers are equal
            Console.WriteLine("Is the first number the largest? " + "No");
			Console.WriteLine("Is the second number the largest? " + "No");
		    Console.WriteLine("Is the  third number the largest? " + "No");			
		}
	}
	 
	public static void Main()
	{
		//Instance of the class
		LargestNumber obj = new LargestNumber();
		//Call the method
		obj.CheckLargestNumber();
	}
}