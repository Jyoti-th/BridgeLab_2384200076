using System;

class LeapYear2 {
	static void Main()
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        // Validate the year
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later (Gregorian calendar).");
            return;
        }

        // Single if statement with logical operators
        if (IsLeapYearLogical(year))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }

    // Using a single if statement with logical operators
    static bool IsLeapYearLogical(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}