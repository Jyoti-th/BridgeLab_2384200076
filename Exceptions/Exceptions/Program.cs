using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
                CallingAllClass caller = new CallingAllClass();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n==== Exception Handling Menu ====");
                    Console.WriteLine("1. Handle File Not Found Exception");
                    Console.WriteLine("2. Handle Division and Input Errors");
                    Console.WriteLine("3. Handle Custom Exception");
                    Console.WriteLine("4. Handle Multiple Exceptions");
                    Console.WriteLine("5. Use using Statement for File Handling");
                    Console.WriteLine("6. Handle Invalid Input in Interest Calculation");
                    Console.WriteLine("7. Demonstrate finally Block Execution");
                    Console.WriteLine("8. Propagate Exceptions Across Methods");
                    Console.WriteLine("9. Use Nested try-catch Blocks");
                    Console.WriteLine("10. Implement Bank Transaction System");
                    Console.WriteLine("0. Exit");
                    Console.Write("\nEnter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            caller.CallingFileNotFound();
                            break;
                        case "2":
                            caller.CallingHandlingDivision();
                            break;
                        case "3":
                            caller.CallingCustomException();
                            break;
                        case "4":
                            caller.CallingMultipleException();
                            break;
                        case "5":
                            caller.CallingUsingStatement();
                            break;
                        case "6":
                            caller.CallingInvalidInput();
                            break;
                        case "7":
                            caller.CallingFinallyBlock();
                            break;
                        case "8":
                            caller.CallingPropagating();
                            break;
                        case "9":
                            caller.CallingNestedTry();
                            break;
                        case "10":
                            caller.CallingBankTransaction();
                            break;
                        case "0":
                            exit = true;
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please try again.");
                            break;
                    }
                }
            }
        }
    }


