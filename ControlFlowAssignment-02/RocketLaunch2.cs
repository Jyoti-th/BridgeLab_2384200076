using System;
public class RocketLaunch2
{
	//Method to perform Countdown operation
	public void CountDown()
	{
		//take counter input
		Console.Write("Enter the counter value = ");
		int counter = Convert.ToInt32(Console.ReadLine());
		
		//For loop to print the countdown numbers
		for(int i = counter; i > 0; i--){
			Console.WriteLine(i);
			
		}
	}
	public static void Main()
	{
		//Instance of the class
        RocketLaunch2 obj = new RocketLaunch2();
        //Call the method
        obj.CountDown();		
	}
}