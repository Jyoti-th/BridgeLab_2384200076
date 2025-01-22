using System;
class UniversityFee
{
	int fee = 125000;
	int discountPercent = 10;
	
	//Method to calculate discounted amount and discounted price
	public void ComputeDiscount()
	{
		//discounted amount 
		int discount = (fee * discountPercent) / 100;
		//discounted price or fees
		int discountedFee = (fee - discount);
		Console.WriteLine("The discount amount is INR "+ discount + " and final discounted fee is INR " + discountedFee);
	}
	
	public static void Main()
	{
		//Instance of a class
		UniversityFee obj = new UniversityFee();
		//Calling the method
		obj.ComputeDiscount();
	}
}