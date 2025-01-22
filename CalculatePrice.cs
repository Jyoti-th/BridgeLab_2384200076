using System;
class CalculatePrice
{
	public void TotalPrice()
	{
		//Input unit price and quantity of an item
		Console.Write("Enter the unit price of an item = ");
		double unitPrice = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter the quantity to be bought = ");
		double quantity = Convert.ToDouble(Console.ReadLine());
		//Calculate the toral price
		double totalPriceOfItem = unitPrice * quantity;
		
		Console.WriteLine("The total purchase price is INR " + totalPriceOfItem +" if the quantity " + quantity + " and unit price is INR " + unitPrice);
		
	}
	
	public static void Main()
	{
		//Instance of a class
		CalculatePrice obj = new CalculatePrice();
		//Calling the method 
		obj.TotalPrice();
	}
}