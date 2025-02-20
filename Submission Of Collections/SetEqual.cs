using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class SetEqual
    {
       public  static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            return set1.SetEquals(set2);
        }

    }
}
