using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutionClass obj = new ExecutionClass();
            Console.WriteLine("Which Question do you want to run 1 to 19 ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    obj.CallingReverseList();
                    break;
                case "2":
                    obj.CallingRotateList();
                    break;
                case "3":
                    obj.CallingListDictionary();
                    break;
                case "4":
                    obj.CallingRemoveDuplicates();
                    break;
                case "5":
                    obj.CallingNthEnd();
                    break;
                case "6":
                    obj.CallingSetEqual();
                    break;
                case "7":
                    obj.CallingUnionIntersection();
                    break;
                case "8":
                    obj.CallingSymmetricDifference();
                    break;
                case "9":
                    obj.CallingSortedList();
                    break;
                case "10":
                    obj.CallingReverseQueue();
                    break;
                case "11":
                    obj.CallingGenerateNumber();
                    break;
                case "12":
                    obj.CallingHospitalHeritage();
                    break;
                case "13":
                    obj.CallingWordFrequency();
                    break;
                case "14":
                    obj.CallingInvertMap();
                    break;
                case "15":
                    obj.CallingInsurancePolicy();
                    break;
                case "16":
                    obj.CallingVotingSystem();
                    break;
                case "17":
                    obj.CallingShoppingCart();
                    break;
                case "18":
                    obj.CallingBankingSystem();
                    break;
                case "19":
                    obj.CallingSuperset();
                    break;
                case "0":
                    Console.WriteLine("Exiting...");
                    return; // Terminates the program
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid number.");
                    break;
            }
        }
    }
}