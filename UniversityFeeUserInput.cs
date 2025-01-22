using System;
class UniversityFee
{	
	//Method to calculate discounted amount and discounted price
	public void ComputeDiscount()
	{
		//Take User Input for fee
		Console.Write("Enter the University Fees = ");
		int fee = Convert.ToInt32(Console.ReadLine());
		//Take User Input for discountpercent
		Console.Write("Enter the Discount percentage offered by the University = ");
		int discountPercent = Convert.ToInt32(Console.ReadLine());

		
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