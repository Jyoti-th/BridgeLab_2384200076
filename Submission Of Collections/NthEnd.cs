using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class NthEnd
    {
        public static string FindNthFromEnd(LinkedList<string> list, int n)
        {
            LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;

            // Move first pointer n steps ahead
            for (int i = 0; i < n; i++)
            {
                if (first == null) return "N is larger than the list size";
                first = first.Next;
            }

            // Move both pointers until first reaches the end
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return second.Value;
        }
    }
}
