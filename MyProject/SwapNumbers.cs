using System;

class SwapNumbers
{
    // Method to swap two numbers
    public void Swap()
    {
		// Take user input for number1
        Console.Write("Enter the first number (number1): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Take user input for number2
        Console.Write("Enter the second number (number2): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

		
        // Swapping numbers using a temporary variable
        int temp = number1;
        number1 = number2;
        number2 = temp;
		
		// Display numbers after swapping
		 Console.WriteLine(" The swapped numbers are " + number1 + " and " + number2);
		
    }

    static void Main()
    {
        //instance of the class
		SwapNumbers obj = new SwapNumbers();
		//Call the method
		obj.Swap();
    }
}
