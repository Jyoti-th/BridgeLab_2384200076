using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class BinaryNumbers
    {
         public static List<string> GenerateBinaryNumbersUsingQueue(int N)
    {
        List<string> binaryNumbers = new List<string>();

        // Create a queue to store the binary numbers
        Queue<string> queue = new Queue<string>();

        // Start by enqueuing the first binary number "1"
        queue.Enqueue("1");

        // Generate binary numbers up to N
        for (int i = 0; i < N; i++)
        {
            // Dequeue the front element (the current binary number)
            string currentBinary = queue.Dequeue();
            // Add the current binary number to the result list
            binaryNumbers.Add(currentBinary);

            // Generate the next two binary numbers and enqueue them
            queue.Enqueue(currentBinary + "0");
            queue.Enqueue(currentBinary + "1");
        }

        return binaryNumbers;
    }

    }
}
