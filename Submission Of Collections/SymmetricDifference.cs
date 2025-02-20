using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class SymmetricDifference
    {
        private HashSet<int> set1;
        private HashSet<int> set2;

        // Constructor
        public SymmetricDifference(HashSet<int> s1, HashSet<int> s2)
        {
            set1 = s1;
            set2 = s2;
        }

        // Method to compute symmetric difference
        public HashSet<int> ComputeSymmetricDifference()
        {
            HashSet<int> symmetricDifference = new HashSet<int>(set1);
            symmetricDifference.SymmetricExceptWith(set2);
            return symmetricDifference;
        }
    }

}

