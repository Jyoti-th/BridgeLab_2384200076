using System;
class NaturalNumber2
{
	//Declare a global variable
	int num;
	
	//Method to check number is natural or not
	public void NumIsNaturalNumber()
	{
		
		while(num>=1)
		{
			int sum = num * (num+1)/2;
				if(formulaResult == sum)
				{
					Console.WriteLine("The sum of "+num+ " natural numbers is "+ sum);
				}
				else{
					Console.WriteLine("The number "+num+" is not a natural number");	
		        }
		}
	 
	 int formulaResult = num * (num+1)/2;

	}
	 
	// Main method
	public static void Main()
	{
		//Instance of the class
		NaturalNumber2 obj = new NaturalNumber2();
		
		//User Input
		Console.Write("Enter the any number= ");
		obj.num = Convert.ToInt32(Console.ReadLine());
	
	    //Call the method
		obj.NumIsNaturalNumber();
	}
}