using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main()
        {
            CallingAllClass call = new CallingAllClass();

            while (true)
            {
                Console.WriteLine("\n===== Stream Operations Menu =====");
                Console.WriteLine("1. Read and Write a Text File");
                Console.WriteLine("2. Buffered File Copy");
                Console.WriteLine("3. Read User Input from Console");
                Console.WriteLine("4. Serialization - Save & Retrieve Employee");
                Console.WriteLine("5. Convert Image to ByteArray");
                Console.WriteLine("6. Convert Uppercase to Lowercase (Filter Streams)");
                Console.WriteLine("7. Store and Retrieve Primitive Data");
                Console.WriteLine("8. Inter-Thread Communication (Piped Streams)");
                Console.WriteLine("9. Read Large File Line by Line");
                Console.WriteLine("10. Count Words in a File");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        call.CallingReadWrite();
                        break;
                    case "2":
                        call.CallingBufferedFile();
                        break;
                    case "3":
                        call.CallingUserInput();
                        break;
                    case "4":
                        call.CallingEmployeeManager();
                        break;
                    case "5":
                        call.CallingImage();
                        break;
                    case "6":
                        call.CallingFilter();
                        break;
                    case "7":
                        call.CallingDataStream();
                        break;
                    case "8":
                        call.CallingPiped();
                        break;
                    case "9":
                        call.CallingLargeFile();
                        break;
                    case "10":
                        call.CallingCountWords();
                        break;
                    case "0":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }
}