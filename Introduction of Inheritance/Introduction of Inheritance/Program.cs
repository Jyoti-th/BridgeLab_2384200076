using Introduction_of_Inheritance.RestaurantManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_of_Inheritance
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Which Question do you want to Run 1 to 11");
            int ques = Convert.ToInt32(Console.ReadLine());
            CallingAllClass callingAllClass = new CallingAllClass();

            switch (ques)
            {
                case 1:
                    callingAllClass.CallingAnimalHierarchy();
                    break;
                case 2:
                    callingAllClass.CallingEmployeeManagement();
                    break;
                case 3:
                    callingAllClass.CallingTransportSystem();
                    break;
                case 4:
                    callingAllClass.CallingLibraryManagement();
                    break;
                case 5:
                    callingAllClass.CallingSmartHomeDevice();
                    break;
                case 6:
                    callingAllClass.CallingOrderManagement();
                    break;
                case 7:
                    callingAllClass.CallingEducationalCourse();
                    break;
                case 8:
                    callingAllClass.CallingBankAccount();
                    break;
                case 9:
                    callingAllClass.CallingSchoolSystem();
                    break;
                case 10:
                    callingAllClass.CallingRestaurantManagment();
                    break;
                case 11:
                    callingAllClass.CallingVehicleManagement();
                    break;

                default:
                    Console.WriteLine("Invalid Question number");
                    break;
            }
            

        }
    }
}
