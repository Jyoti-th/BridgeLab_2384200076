using System;
class NaturalNumber
{
	//Declare a global variable
	int num;
	
	//Method to check number is natural or not
	public void NumIsNaturalNumber()
	{
		
		if(num<1)
		{
			Console.WriteLine("The number "+num+" is not a natural number");

		}
		else
		{
			SumNatural();	
		}
	}
	//Method to calculate the sum of natural number
	public void SumNatural()
	{
			int sum = num * (num+1)/2;
			Console.WriteLine("The sum of "+num+ " natural numbers is "+ sum);	
	}
	// Main method
	public static void Main()
	{
		//Instance of the class
		NaturalNumber obj = new NaturalNumber();
		
		//User Input
		Console.WriteLine("Enter the any number");
		obj.num = Convert.ToInt32(Console.ReadLine());
	
	    //Call the method
		obj.NumIsNaturalNumber();
	}
}