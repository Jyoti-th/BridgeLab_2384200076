using System;
class Factors
{
	public static void Main()
	{
		Factor();	
	}
	public static void Factor()
	{
		//take the user input and convert it into integer
		Console.Write("Enter any number: ");
		int n = int.Parse(Console.ReadLine());
		
		// create integer variable maxFactor and initialize to 10
		int maxFactor = 10;
		
		//create factors array of size maxFactor
		int [] factor = new int[maxFactor];
		
		//variable that calculate index
		int index=0;
		
		//loop that will run till n 
		for(int i =1;i<=n;i++)
		{
			// check i is a factor of n 
			if(n%i==0)
			{
				factor[index] = i;
				index++;
			}
			//check index is reach to the size of maxfactor=10
			if(index == maxFactor)
			{
				//double the size 
				maxFactor *=2;
				
				//take the temperoary array 
				int [] temp = new int[maxFactor];
				
				// copy the elements from the factor array to temperoary array
				for(int j=0;j<factor.Length;j++)
				{
					temp[j] = factor[j];
				}
				
				//copy the value again to the original array 
				factor = temp;
			}
		
		}	
		
		// print all the factors of the number
		Console.WriteLine("Factors of " + n + ": ");
		for(int j = 0;j<index;j++)
		{
			Console.Write(factor[j]+ " ");
		}
		
	}
}