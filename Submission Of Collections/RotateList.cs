using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class RotateUsingList
    {
        public static List<int> RotateList(List<int> numbers, int positions)
        {
            int n = numbers.Count;
            positions = positions % n; // Ensure rotation doesn't exceed list size

            List<int> rotated = new List<int>();
            rotated.AddRange(numbers.GetRange(positions, n - positions));
            rotated.AddRange(numbers.GetRange(0, positions));

            return rotated;
        }
    }
}
