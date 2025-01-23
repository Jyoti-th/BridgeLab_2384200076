using System;
public class Vote
{
	int requiredAge = 18;
	//Method to check age of person for voting
	public void VotingAge()
	{
		Console.Write("Enter the Age : ");
		int age = Convert.ToInt32(Console.ReadLine());
		 
		//Check person can vote or not 
		if(age >= requiredAge)
		{
			Console.WriteLine("The person's age is " + age + " and can vote.");
		}
		else{
			Console.WriteLine("The person's age is "+ age + " and cannot vote.");
		}
	}
	public static void Main()
	{
		Vote obj = new Vote();
		//Call the method
		obj.VotingAge();
	}
}