using System;
class SimpleInterest
{
	public static int CalculateInterest(int principal, int rate, int time)
	{
		return (principal*rate*time)/100;
	}
	
	public static void Main(String[] args)
	{
		Console.Write("Enter the Principal Amount : ");
		int principal = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the rate of Amount : ");
		int rate = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the Time duration : ");
		int time = Convert.ToInt32(Console.ReadLine());
		
		int result = CalculateInterest(principal, rate, time);
		
		Console.WriteLine("The Simple Interest is " + result + " for Principal " + principal + ", Rate of Interest " + rate+ " and Time " + time);
		
	}
}