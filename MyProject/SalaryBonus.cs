using System;

class SalaryBonus
{
    // Method to calculate and display the total income
    public void CalculateIncome()
    {
		// Take user input for salary
        Console.Write("Enter your salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());
		
		 // Take user input for bonus
        Console.Write("Enter your bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());
		
        // Compute total income
        double totalIncome = salary + bonus;

        // Display the results
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence, Total Income is INR "+ totalIncome);
    }

    static void Main(string[] args)
    {
      //Instance of the class
	     SalaryBonus obj = new SalaryBonus();
	  // Call the method to calculate income
        obj.CalculateIncome();
    }
}
