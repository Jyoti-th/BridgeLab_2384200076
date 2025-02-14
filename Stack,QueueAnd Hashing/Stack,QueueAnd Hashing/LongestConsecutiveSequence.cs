using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class LongestConsecutiveSequence
    {
        public static int FindLongestSequence(int[] arr)
        {
            HashSet<int> numSet = new HashSet<int>(arr);
            int maxLength = 0;

            foreach (int num in arr)
            {
                // Check if it's the start of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    // Extend the sequence
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }

                    // Update max length
                    maxLength = Math.Max(maxLength, currentLength);
                }
            }

            return maxLength;
        }

       
    }
}
