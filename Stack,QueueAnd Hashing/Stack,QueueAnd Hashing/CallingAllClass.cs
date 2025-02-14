using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    public class CallingAllClass
    {
        public void CallingQueueUsingStacks()
        {
            QueueUsingStack queue = new QueueUsingStack(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Enqueue(40);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
        }

        public void CallingSortStack()
        {
            SortStack stack = new SortStack(5);

            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);
            stack.Push(5);

            Console.WriteLine("Original Stack:");
            stack.Display();

            stack.SortAStack();

            Console.WriteLine("\nSorted Stack:");
            stack.Display();
        }

        public void CallingStockSpan()
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int[] span = CalculateSpan(prices);

            Console.WriteLine("Stock Spans:");
            foreach (int s in span)
            {
                Console.Write(s + " ");
            }
        }

        public void CallingSlidingWindowMax()
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            FindMaxInWindow(arr, k);
        }

        public void CallingCircularTour()
        {
                int[] petrol = { 4, 6, 7, 4 };  // Petrol available at each pump
                int[] distance = { 6, 5, 3, 5 }; // Distance to next pump
                int n = petrol.Length;

                int result = FindStartingPoint(petrol, distance, n);
                Console.WriteLine((result != -1) ? $"Start at pump {result}" : "No valid start point");
        }

        public void CallingSubarrayZeroSum()
        {
            
                int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
                FindZeroSumSubarrays(arr);
            
        }

        public void CallingPairWithGivenSum()
        {
            
                int[] arr = { 8, 4, 7, 1, 5, 9 };
                int target = 10;
                FindPair(arr, target);
            
        }

        public void CallingLongestConsecutiveSequence()
        {
            
                int[] arr = { 100, 4, 200, 1, 3, 2 };
                Console.WriteLine("Longest Consecutive Sequence Length: " + FindLongestSequence(arr));
            
        }
        public void CallingCustomHashMap()
        {
            
                CustomHashMap map = new CustomHashMap(10);

                map.Put(1, 100);
                map.Put(2, 200);
                map.Put(11, 300); // Collides with key 1

                Console.WriteLine("Get(1): " + map.Get(1)); // Output: 100
                Console.WriteLine("Get(2): " + map.Get(2)); // Output: 200
                Console.WriteLine("Get(11): " + map.Get(11)); // Output: 300

                map.Remove(1);
                Console.WriteLine("Get(1) after deletion: " + map.Get(1)); // Output: -1
            
        }

        public void CallingTwoSumProblem()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSumSolution.TwoSum(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
    

    
