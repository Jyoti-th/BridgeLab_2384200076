﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class SubarrayZeroSum
    {
  
        public static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            
            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; // Cumulative sum

                if (map.ContainsKey(sum)) 
                {
                    foreach (int start in map[sum])
                    {
                        Console.WriteLine($"Subarray found from index {start + 1} to {i}");
                    }
                }

                
                if (!map.ContainsKey(sum))
                    map[sum] = new List<int>();

                map[sum].Add(i);
            }
        }

       
    
}
}
