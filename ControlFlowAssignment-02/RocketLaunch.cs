using System;
public class RocketLaunch
{
	//Method to perform Countdown operation
	public void CountDown()
	{
		//take counter input
		Console.Write("Enter the counter value = ");
		int counter = Convert.ToInt32(Console.ReadLine());
		//While loop to print the countdown numbers
		while(counter != 0){
			Console.WriteLine(counter);
			counter--;
		}
	}
	public static void Main()
	{
		//Instance of the class
        RocketLaunch obj = new RocketLaunch();
        //Call the method
        obj.CountDown();		
	}
}