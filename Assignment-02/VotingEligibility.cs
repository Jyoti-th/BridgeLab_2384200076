using System;

public class VotingEligibility
{
    // Declare a static array to store the ages of 10 students
    static int[] studentAges = new int[10];

    public static void Main()
    {
        Console.WriteLine("Enter the ages of 10 Students:");

        // Input and validate the ages of students
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());

            // Validate the input
            if (studentAges[i] < 0)
            {
                Console.Error.WriteLine("Invalid input! Age cannot be negative. Exiting...");
                Environment.Exit(0); // Exit the program
            }
        }

        // Call the method to check voting eligibility
        CheckAge();
    }

    // Method to check voting eligibility
    public static void CheckAge()
    {
        Console.WriteLine("\nVoting Eligibility Results:");
        for (int i = 0; i < studentAges.Length; i++)
        {
            if (studentAges[i] >= 18)
            {
                Console.WriteLine("The student with the age " + studentAges[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age " + studentAges[i] + " cannot vote.");
            }
        }
    }
}
