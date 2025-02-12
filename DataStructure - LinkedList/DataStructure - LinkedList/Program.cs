using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructure___LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Question do you want to Run 1 to 9");
            int ques = Convert.ToInt32(Console.ReadLine());
            CallingAllClass callingAllClass = new CallingAllClass();

            switch (ques)
            {
                case 1:
                    callingAllClass.CallingStudentRecordManagement();
                    break;
                case 2:
                    callingAllClass.CallingMovieManagement();
                    break;
                case 3:
                    callingAllClass.CallingTaskSchedular();
                    break;
                case 4:
                    callingAllClass.CallingInventoryManagement();
                    break;
                case 5:
                    callingAllClass.CallingLibraryManagement();
                    break;
                case 6:
                    callingAllClass.CallingRoundRobin();
                    break;
                case 7:
                    callingAllClass.CallingSocialMedia();
                    break;
                case 8:
                    callingAllClass.CallingTextEditor();
                    break;
                case 9:
                    callingAllClass.CallingTicketReservation();
                    break;


                default:
                    Console.WriteLine("Invalid Question number");
                    break;
            }
            Console.ReadKey();
                

        }
    }
}
