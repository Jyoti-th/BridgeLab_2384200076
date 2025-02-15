using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Program
    {
        public static void Main()
        {
            CallingAllClass sortingCaller = new CallingAllClass(); // Create an object of CallingAllClass

            while (true) // Loop to allow multiple choices
            {
                Console.WriteLine("\nChoose a sorting algorithm:");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Insertion Sort");
                Console.WriteLine("3. Merge Sort");
                Console.WriteLine("4. Quick Sort");
                Console.WriteLine("5. Selection Sort");
                Console.WriteLine("6. Heap Sort");
                Console.WriteLine("7. Counting Sort");
                Console.WriteLine("8. Exit");

                Console.Write("\nEnter your choice (1-8): ");
                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice); // Validate input

                if (!isValidChoice)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        sortingCaller.CallingBubbleSort();
                        break;

                    case 2:
                        sortingCaller.InsertionSortProgram();
                        break;

                    case 3:
                        sortingCaller.MergeSortProgram();
                        break;

                    case 4:
                        sortingCaller.CallingQuickSortProgram();
                        break;

                    case 5:
                        sortingCaller.CallingSelectionSortProgram();
                        break;

                    case 6:
                        sortingCaller.CallingHeapSortProgram();
                        break;

                    case 7:
                        sortingCaller.CallingCountingSortProgram();
                        break;

                    case 8:
                        Console.WriteLine("Exiting program...");
                        return; // Exit the program

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 8.");
                        break;
                }

                Console.WriteLine("\nDo you want to choose another sorting algorithm? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    Console.WriteLine("Exiting program...");
                    break;


                   


                }
            }
        }
    }
}
