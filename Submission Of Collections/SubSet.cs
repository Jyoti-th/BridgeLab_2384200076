using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class SubSet
    {
        public static bool IsSubset(HashSet<int> subset, HashSet<int> superset)
        {
            return superset.IsSupersetOf(subset);
        }
    }
}
