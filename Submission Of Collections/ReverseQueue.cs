using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class ReverseQueue
    {
        // Method to reverse a queue using recursion
        public static void ReverseQueueUsingRecursion(Queue<int> queue)
        {
            // Base case: If the queue is empty, return
            if (queue.Count == 0)
            {
                return;
            }

            // Recursive case: Dequeue the front element
            int front = queue.Dequeue();

            // Reverse the remaining queue
            ReverseQueueUsingRecursion(queue);

            // Enqueue the dequeued element back into the queue
            queue.Enqueue(front);
        }

    }
}
