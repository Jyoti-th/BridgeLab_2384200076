using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    
    public class ReverseList
    {
        // Method to reverse an ArrayList
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }

        // Method to reverse a LinkedList
        public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int item in list)
            {
                reversedList.AddFirst(item);
            }
            return reversedList;
        }
    }

}
