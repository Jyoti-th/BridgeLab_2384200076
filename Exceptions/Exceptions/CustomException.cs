using System;
namespace Exceptions
{
    // Custom Exception Class
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class CustomExcepiton
    {
        // Method to validate age
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above");
            }
            else
            {
                Console.WriteLine("Access granted!");
            }
        }

        public static void Method()
        {
            try
            {
                // Taking user input
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Calling ValidateAge method
                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numeric age.");
            }
        }
    }
}
