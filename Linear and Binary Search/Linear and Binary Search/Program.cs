using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_and_Binary_Search
{
    class Program
    {
        static void Main()
        {
            CallingAllClass obj = new CallingAllClass();

            while (true) 
            {
                Console.WriteLine("\n==== Select an Operation ====");
                Console.WriteLine("1. Reverse a String");
                Console.WriteLine("2. Remove Duplicates from String");
                Console.WriteLine("3. Concatenate Strings");
                Console.WriteLine("4. Compare StringBuilder Performance");
                Console.WriteLine("5. Read File Line by Line");
                Console.WriteLine("6. Count Word Occurrence in File");
                Console.WriteLine("7. Convert Byte Stream to Character Stream");
                Console.WriteLine("8. Read User Input & Write to File");
                Console.WriteLine("9. Find First Negative Number (Linear Search)");
                Console.WriteLine("10. Find Specific Word in Sentences");
                Console.WriteLine("11. Find Rotation Point in Rotated Sorted Array");
                Console.WriteLine("12. Find Peak Element");
                Console.WriteLine("13. Search in 2D Sorted Matrix");
                Console.WriteLine("14. Find First & Last Occurrence in Sorted Array");
                Console.WriteLine("15. Challenge Problem (Missing Positive & Binary Search)");
                Console.WriteLine("0. Exit");

                Console.Write("\nEnter your choice: ");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        obj.CallingReverseString();
                        break;
                    case 2:
                        obj.CallingRemoveDuplicates();
                        break;
                    case 3:
                        obj.CallingConcatenateString();
                        break;
                    case 4:
                        obj.CallingCompare();
                        break;
                    case 5:
                        obj.CallingFile();
                        break;
                    case 6:
                        obj.CallingWord();
                        break;
                    case 7:
                        obj.CallingConvertor();
                        break;
                    case 8:
                        obj.CallingUserInput();
                        break;
                    case 9:
                        obj.CallingLinearSearchProgram();
                        break;
                    case 10:
                        obj.CallingFindWord();
                        break;
                    case 11:
                        obj.CallingFindRotationPoint();
                        break;
                    case 12:
                        obj.CallingPeakElement();
                        break;
                    case 13:
                        obj.CallingSortedMatrix();
                        break;
                    case 14:
                        obj.CallingOccurance();
                        break;
                    case 15:
                        obj.CallingSearchOperations();
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }

            
        }
    }
}
