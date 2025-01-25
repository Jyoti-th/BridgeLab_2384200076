using System;
class FootballTeam
{
	public static void Main()
	{
		//call method
		MeanHeight();
	}
	public static void MeanHeight()
	{
		double sum=0.0;
		
		Console.WriteLine("Enter the height of all 11 players");
		
		//declar an array and initialize
		double [] num = new double [11];
		
		// enter the height of all the players  and calculate sum
		for(int i=0;i<num.Length;i++)
		{
			Console.WriteLine("Enter the height of "+ (i+1) +" players");
			num[i] = double.Parse(Console.ReadLine());	
			sum+=num[i];
		}
		// calculate mean height 
		double mean = sum/11;
		//print the result
		Console.WriteLine("The mean height of the football team "+mean);
	}

}