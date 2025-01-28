using System;

public class StudentVoteChecker
{
    // Method to check if a student can vote
    public bool CanStudentVote(int age)
    {
        // Validate the age
        if (age < 0)
        {
            return false; // Negative age, cannot vote
        }

        // Check if age is 18 or above
        return age >= 18;
    }
}

class StudentVote
{
    public static void Main(string[] args)
    {
        // Array to store ages of 10 students
        int[] studentAges = new int[10];
        StudentVoteChecker voteChecker = new StudentVoteChecker();

        Console.WriteLine("Enter the age of 10 students:");

        for (int i = 0; i < studentAges.Length; i++)
        {
            // Declare age variable separately
            int age;
            Console.Write("Student {0} age: ", i + 1);
            if (int.TryParse(Console.ReadLine(), out age)) // Parse input
            {
                studentAges[i] = age;

                // Call the CanStudentVote method
                bool canVote = voteChecker.CanStudentVote(age);

                // Display the result
                if (age < 0)
                {
                    Console.WriteLine("Student {0}: Invalid age. Cannot vote.\n", i + 1);
                }
                else if (canVote)
                {
                    Console.WriteLine("Student {0}: Can vote.\n", i + 1);
                }
                else
                {
                    Console.WriteLine("Student {0}: Cannot vote.\n", i + 1);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Retry the current student's input
            }
        }
    }
}
