using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class UserInputToFile
    {
 
        public static void SaveData()
        {
            string filePath = "UserData.txt";  // File to store user input

            try
            {
                // Taking user input
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                string age = Console.ReadLine();

                Console.WriteLine("Enter your favorite programming language:");
                string language = Console.ReadLine();

                // Writing user input to file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("User Details:");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Age: {age}");
                    writer.WriteLine($"Favorite Programming Language: {language}");
                }

                Console.WriteLine($"User data saved successfully in {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }

}
