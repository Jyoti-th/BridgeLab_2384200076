using System;

class ChocolateDistribution
{
	public void Chocolates()
	{
		 // Take user input for the number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
		
		 // Display the results
        Console.WriteLine ("The number of chocolates each child gets is "+chocolatesPerChild+ " and the number of remaining chocolates is "+remainingChocolates);
	}
    public static void Main(string[] args)
    {		
     ChocolateDistribution obj = new ChocolateDistribution();
     obj.Chocolates();	 
    }
}
