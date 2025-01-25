using System;
class FizzBuzzNum
{
public static void Main()
{
	//call the method
	FizzBuzz();
}
public static void FizzBuzz()
{
	//take the input and convert it into int 
	Console.WriteLine("Enter any number");
	int n = int.Parse(Console.ReadLine());
	
	//declare and initialize the array
	String [] arr = new String[n];
	
	// if user didn't enter the negative positive integer exit
	if(n<=0)
	{
		 Console.WriteLine("Please enter a valid positive number.");
		 return;
	}
	
		//run the loop 
		for(int i=0;i<n;i++)
		{
			//condition check for fizzbuzz
			if((i+1)%3==0 && (i+1)%5==0)
			{
				arr[i]="FizzBuzz";
			}
			//condition check for fizz
			else if((i+1)%3==0)
			{
				arr[i]="Fizz";
			}
			//condition check for buzz
			else if((i+1)%5==0)
			{
				arr[i]="Buzz";
			}
			
			//store the no. itself
			else{
				arr[i]=Convert.ToString(i+1);
			}
		}

	//print the result
	for(int i=0;i<n;i++)
	{
		Console.WriteLine("Position" +(i+1)+" = "+arr[i]);
	}
}

}
