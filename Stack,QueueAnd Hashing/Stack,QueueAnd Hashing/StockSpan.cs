using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueAnd_Hashing
{
    class StockSpan
    {
  
        public static int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n]; // To store span for each day
            int[] stack = new int[n]; // Stack to store indices
            int top = -1; // Stack pointer

            for (int i = 0; i < n; i++)
            {
                // Pop elements from stack while stack is not empty and prices[stack[top]] <= prices[i]
                while (top >= 0 && prices[stack[top]] <= prices[i])
                {
                    top--;
                }

                // If stack is empty, span = i + 1 (all previous days were smaller)
                // Else span = i - stack[top] (previous greater element)
                span[i] = (top == -1) ? (i + 1) : (i - stack[top]);

                // Push this day's index onto the stack
                stack[++top] = i;
            }

            return span;
        }

       
    }

}

