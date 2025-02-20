using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class RemoveOrderDuplicates
    {
      public  static List<int> RemoveDuplicates(List<int> numbers)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> uniqueNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (!seen.Contains(num))
                {
                    seen.Add(num);
                    uniqueNumbers.Add(num);
                }
            }

            return uniqueNumbers;
        }
    }
}
