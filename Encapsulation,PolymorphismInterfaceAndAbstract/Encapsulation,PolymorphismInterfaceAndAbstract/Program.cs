using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_PolymorphismInterfaceAndAbstract
{



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Question do you want to Run 1 to 8");
            int ques = Convert.ToInt32(Console.ReadLine());
            CallingAllClass callingAllClass = new CallingAllClass();

            switch (ques)
            {
                case 1:
                    callingAllClass.CallingEmployeeManagement();
                    break;
                case 2:
                    callingAllClass.CallingEcommerce();
                    break;
                case 3:
                    callingAllClass.CallingVehicle();
                    break;
                case 4:
                    callingAllClass.CallingBankAccount();
                    break;
                case 5:
                    callingAllClass.CallingLibraryItem();
                    break;
                case 6:
                    callingAllClass.CallingFoodItem();
                    break;
                case 7:
                    callingAllClass.CallingPatient();
                    break;
                case 8:
                    callingAllClass.CallingRide();
                    break;
                

                default:
                    Console.WriteLine("Invalid Question number");
                    break;
            }





            Console.ReadKey();
        }
    }
}
