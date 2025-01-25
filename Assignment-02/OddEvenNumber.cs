using System;
class OddEvenNumber
{
	public static void Main()
	{
		OddEven();	
	}
	public static void OddEven()
	{
		//take the user input and convert it into integer
		Console.Write("Enter any number: ");
		int n = int.Parse(Console.ReadLine());
		if(n<=0)
		{
			Console.WriteLine("Entered no. is not a natural number");
			Environment.Exit(1);
		}
			
			
		int [] oddArr = new int[n / 2 + 1];
		int [] evenArr = new int[n / 2 + 1];
		int oddIndex = 0; int evenIndex = 0;
		for(int i=1; i<=n;i++)
		{
			if(i%2!=0)
			{
				oddArr[oddIndex]= i;
				oddIndex++;
			}
			else
			{
				evenArr[evenIndex]=i;
				evenIndex++;
			}
			
		}
		Console.Write("Odd Numbers: ");
		for(int i=0;i<oddIndex;i++)
		{
			Console.Write(oddArr[i]+" ");
		}
		 Console.WriteLine();
		 
		Console.Write("Even Numbers: ");
		for(int i=0;i<evenIndex;i++)
		{
			Console.Write(evenArr[i]+" " );
		}
		
		
	}
}