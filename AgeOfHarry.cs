using System; 
namespace Qustion1
{
class AgeOfHarry
{
	int birthYear = 2000;      // Harry's birth year
	int currentYear = 2024;    // current year
	
	
	//Method to calculate age 
	public int CalculateAge() 
	{
		return currentYear-birthYear;// return calculated age 
	}
	public static void Main()
	{	
        //Create an instance of the class	
	    AgeOfHarry obj = new AgeOfHarry();
		
		//Display the result by calling method CalculateAge
		Console.WriteLine("The Age of Harry is " + obj.CalculateAge());
		
	}
}
}