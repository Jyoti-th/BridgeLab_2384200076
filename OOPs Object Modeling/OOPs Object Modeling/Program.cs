using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Object_Modeling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which Question do you want to Run 1 to 8");
            int ques = Convert.ToInt32(Console.ReadLine());
            CallingAllClasses callingAllClass = new CallingAllClasses();

            switch (ques)
            {
                case 1:
                    callingAllClass.CallingLibrary();
                    break;
                case 2:
                    callingAllClass.CallingBankAccount();
                    break;
                case 3:
                    callingAllClass.CallingEmployee();
                    break;
                case 4:
                    callingAllClass.CallingCourse();
                    break;
                case 5:
                    callingAllClass.CallingFaculty();
                    break;
                case 6:
                    callingAllClass.CallingPatientHospital();
                    break;
                case 7:
                    callingAllClass.CallingEcommerce();
                    break;
                 case 8:
                    callingAllClass.CallingUniversityManagement();
                    break;
                default:
                    Console.WriteLine("Invalid Question number");
                    break;


            }
            Console.ReadKey();
        }
        }
    }

