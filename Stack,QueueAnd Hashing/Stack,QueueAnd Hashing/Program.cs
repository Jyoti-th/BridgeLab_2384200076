using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallingAllClass callingAllClass = new CallingAllClass();


            Console.WriteLine("which Question do you want to run 1 to 10");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {

                case 1:
                    callingAllClass.CallingQueueUsingStacks();
                    break;

                case 2:
                    callingAllClass.CallingSortStack();
                    break;

                case 3:
                    callingAllClass.CallingStockSpan();
                    break;

                case 4:
                    callingAllClass.CallingSlidingWindowMax();
                    break;
                case 5:
                    callingAllClass.CallingCircularTour();
                    break;

                case 6:
                    callingAllClass.CallingSubarrayZeroSum();
                    break;

                case 7:
                    callingAllClass.CallingPairWithGivenSum();
                    break;

                case 8:
                    callingAllClass.CallingLongestConsecutiveSequence();
                    break;


                case 9:
                    callingAllClass.CallingCustomHashMap();
                    break;

                case 10:
                    callingAllClass.CallingTwoSumProblem();
                    break;

                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
        
