using System;
class NaturalNumberForLoop
{
	//Declare a global variable
	int num;
	int formulaResult;
	
	//Method to check number is natural or not
	public void NumIsNaturalNumber()
	{
		
		for(int i = num; i > 0;)
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
	 
	 formulaResult = num * (num+1)/2;

	}
	 
	// Main method
	public static void Main()
	{
		//Instance of the class
		NaturalNumberForLoop obj = new NaturalNumberForLoop();
		
		//User Input
		Console.Write("Enter the any number= ");
		obj.num = Convert.ToInt32(Console.ReadLine());
	
	    //Call the method
		obj.NumIsNaturalNumber();
	}
}