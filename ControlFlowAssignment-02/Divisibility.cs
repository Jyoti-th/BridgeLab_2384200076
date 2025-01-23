using System;
public class Divisibility
{   
//Method to check divisibility
public void Calculate()
{

//take input number to check divisible by 5
	Console.Write("Enter the number = ");
	double num = Convert.ToDouble(Console.ReadLine());
	
	// Check divisibility using IF statement Wheteher num is divisible by 5 or not
	if(num % 5 == 0)
	{
		//Print result
		Console.WriteLine("Is the number " + num +" divisible by 5? "+ "Yes");
	}
	else{
		//Print result
		Console.WriteLine("Is the number " + num +" divisible by 5? "+ "No");
	}

}

public static void Main()
{
	//Instance of the class
	Divisibility obj = new Divisibility();
	// Calling the method
	obj.Calculate();
}
}