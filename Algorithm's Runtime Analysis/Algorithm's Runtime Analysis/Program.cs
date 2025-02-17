using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_s_Runtime_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            CallingAllClass obj = new CallingAllClass();

            while (true)
            {
                Console.WriteLine("\nSelect an option to test:");
                Console.WriteLine("1. Search Target in Large Dataset");
                Console.WriteLine("2. Sorting Large Data Efficiently");
                Console.WriteLine("3. String Concatenation Performance");
                Console.WriteLine("4. Large File Reading Efficiency");
                Console.WriteLine("5. Recursive vs Iterative Fibonacci Computation");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        obj.CallingSearchTarget();
                        break;
                    case 2:
                        obj.CallingSortingComparison();
                        break;
                    case 3:
                        obj.CallingStringConcatenation();
                        break;
                    case 4:
                        obj.CallingFileReading();
                        break;
                    case 5:
                        obj.CallingFibbonacciComparison();
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
