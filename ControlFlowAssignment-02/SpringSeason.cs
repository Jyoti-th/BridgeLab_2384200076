using System;
class SpringSeason
{
	public static void Main(string[] args)
	{
		//Command-Line arguments Validation
		if(args.Length < 2)
		{
			Console.WriteLine("Please Provide month and day as command line argument");
			return;
		}
		
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
		//Method to check the season is Spring or not
        if (IsSpringSeason(month, day))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
	//Method to process spring season months
    public static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20 && day <= 31) ||
            (month == 4 && day >= 1 && day <= 30) ||
            (month == 5 && day >= 1 && day <= 31) ||
            (month == 6 && day >= 1 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
