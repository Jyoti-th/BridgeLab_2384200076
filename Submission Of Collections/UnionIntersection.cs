using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class UnionIntersection
    {
        private HashSet<int> set1;
        private HashSet<int> set2;

        // Constructor
        public UnionIntersection(HashSet<int> s1, HashSet<int> s2)
        {
            set1 = s1;
            set2 = s2;
        }

        // Method to compute union
        public HashSet<int> ComputeUnion()
        {
            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2);
            return unionSet;
        }

        // Method to compute intersection
        public HashSet<int> ComputeIntersection()
        {
            HashSet<int> intersectionSet = new HashSet<int>(set1);
            intersectionSet.IntersectWith(set2);
            return intersectionSet;
        }
    }
}

