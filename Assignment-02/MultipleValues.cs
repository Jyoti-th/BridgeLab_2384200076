using System;
public class MultipleValues
{
	public static void Main()
	{
	ShowSum();
	}
	
	//Method to Show all the numbers as well as the sum of all numbers 
	public static void ShowSum()
	{
		double total = 0.0;	
		int i=0;
		
		
		Console.WriteLine("Enter 10 numbers");
		double [] num = new double[10];
			while(true)
			{
				Console.Write("Enter "+(i+1)+" number: ");	
				double var = Convert.ToDouble(Console.ReadLine());
			
				if( var <=0)
				{
					Console.WriteLine("Stopping input as you entered 0 or a negative number.");
					break;
				}
				if(i==10)
				{
					Console.WriteLine("Array is full. No more numbers can be entered.");
					break;
				}
				num[i] =var;
				i++;
			}		
		for(int j=0;j<i;j++)
		{
				Console.WriteLine(num[j]);
				total+=num[j];
		}
		Console.WriteLine("The total sum of the entered numbers is: " +total);
	}
}