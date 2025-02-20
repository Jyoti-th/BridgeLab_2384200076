using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class SortedList
    {
       public static List<int> ConvertToSortedList(HashSet<int> set)
        {
            List<int> sortedList = new List<int>(set);
            sortedList.Sort();
            return sortedList;
        }
    }
}
