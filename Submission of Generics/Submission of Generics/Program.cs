using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Generics
{
    class Program
    {
        static void Main(string[] args)
        {   
                CallingAllClass caller = new CallingAllClass();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n=== GENERIC SYSTEM MENU ===");
                    Console.WriteLine("1. Smart Warehouse Management System");
                    Console.WriteLine("2. Dynamic Online Marketplace");
                    Console.WriteLine("3. Multi-Level University Course Management System");
                    Console.WriteLine("4. Personalized Meal Plan Generator");
                    Console.WriteLine("5. AI-Driven Resume Screening System");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");

                    string input = Console.ReadLine();
                    Console.WriteLine(); // New line for clarity

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine(" Running Smart Warehouse Management System...");
                            caller.CallingWarehouse();
                            break;

                        case "2":
                            Console.WriteLine(" Running Dynamic Online Marketplace...");
                            caller.CallingOnlineMarketplace();
                            break;

                        case "3":
                            Console.WriteLine("Running Multi-Level University Course Management System...");
                            caller.CallingCourse();
                            break;

                        case "4":
                            Console.WriteLine("Running Personalized Meal Plan Generator...");
                            caller.CallingMealPlan();
                            break;

                        case "5":
                            Console.WriteLine("Running AI-Driven Resume Screening System...");
                            caller.CalingResume();
                            break;

                        case "0":
                            Console.WriteLine("Exiting the program...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please enter a valid option.");
                            break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear(); // Clears the console for better readability
                }
            }
        }
    }


