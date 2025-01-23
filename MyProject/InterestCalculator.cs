using System;

class InterestCalculator
{
	public void SimpleInterest()
	{
		// Take user input for Principal
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Take user input for Rate of Interest
        Console.Write("Enter the Rate of Interest (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Take user input for Time (in years)
        Console.Write("Enter the Time period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;
		
		// Print the result
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time "+time);
		
	}
    public static void Main(string[] args)
    {
        InterestCalculator obj = new InterestCalculator();
		obj.SimpleInterest();
    }
}
