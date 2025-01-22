using System;
class ProfitAndLoss
{	
    int costPrice = 129;
	int sellingPrice = 191;

	//Method to calculate Profit and Profit Percentage
	public void CalculateProfit()
	{
		int profit = sellingPrice-costPrice;
		double profitPercentage = (profit / (double)costPrice) * 100;
		
		//Display the Result
		Console.WriteLine(" The Cost Price is INR " +costPrice+ " and SellingPrice is INR " + 
		sellingPrice + "\n The Profit is INR " + profit + " and The Profit Percentage is "+ profitPercentage);
	}
	
	public static void Main()
	{
		//Instance of class
		ProfitAndLoss obj = new ProfitAndLoss();
		//Method Calling
		obj.CalculateProfit();
		
	}
}