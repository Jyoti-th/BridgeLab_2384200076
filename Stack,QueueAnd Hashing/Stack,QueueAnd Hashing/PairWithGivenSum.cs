using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class PairWithGivenSum
    {
        
        public static void FindPair(int[] arr, int target)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];

                if (map.ContainsKey(complement))
                {
                    Console.WriteLine($"Pair found ({arr[i]}, {complement})");
                    return;
                }

                if (!map.ContainsKey(arr[i]))
                {
                    map[arr[i]] = true;
                }
            }

            Console.WriteLine("No valid pair found.");
        }

       
    }

}

