using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class CircularTour
    {
  
        public static int FindStartingPoint(int[] petrol, int[] distance, int n)
        {
            int total_petrol = 0, total_distance = 0;
            int start = 0, surplus = 0;

            for (int i = 0; i < n; i++)
            {
                total_petrol += petrol[i];
                total_distance += distance[i];

                surplus += petrol[i] - distance[i]; // Net petrol balance

                if (surplus < 0) // If we run out of petrol, change start
                {
                    start = i + 1;
                    surplus = 0; // Reset surplus
                }
            }

            return (total_petrol >= total_distance) ? start : -1;
        }

       
    }


}
