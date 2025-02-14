using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class SlidingWindowMax
    {
 
        public static void FindMaxInWindow(int[] arr, int k)
        {
            if (arr.Length == 0 || k > arr.Length)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int[] result = new int[arr.Length - k + 1]; // Store final result
            int index = 0;

           
            int[] deque = new int[arr.Length]; // Stores indices
            int front = 0, rear = -1; // Deque pointers

            for (int i = 0; i < arr.Length; i++)
            {
                // Remove elements out of current window
                if (front <= rear && deque[front] <= i - k)
                    front++;

                // Remove all smaller elements from rear
                while (front <= rear && arr[deque[rear]] <= arr[i])
                    rear--;

                // Insert current index in deque
                deque[++rear] = i;

                // Store the maximum value of current window
                if (i >= k - 1)
                    result[index++] = arr[deque[front]];
            }

            // Print Result
            Console.WriteLine("Sliding Window Maximum:");
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        
    }

}
