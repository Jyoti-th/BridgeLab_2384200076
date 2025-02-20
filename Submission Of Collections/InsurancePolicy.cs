using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class Policy
    {
        public string PolicyNumber { get; set; }
        public string PolicyholderName { get; set; }
        public string CoverageType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Amount { get; set; }

        public Policy(string policyNumber, string policyholderName, string coverageType, DateTime startDate, DateTime expiryDate, decimal amount)
        {
            PolicyNumber = policyNumber;
            PolicyholderName = policyholderName;
            CoverageType = coverageType;
            StartDate = startDate;
            ExpiryDate = expiryDate;
            Amount = amount;
        }

        // Overriding Equals and GetHashCode for uniqueness in HashSet and SortedSet
        public override bool Equals(object obj)
        {
            if (obj is Policy policy)
            {
                return this.PolicyNumber == policy.PolicyNumber;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        // Display policy details
        public override string ToString()
        {
            return $"{PolicyNumber} - {PolicyholderName} - {CoverageType} - {StartDate.ToShortDateString()} - {ExpiryDate.ToShortDateString()} - {Amount:C}";
        }
    }

    class InsurancePolicyManagementSystem
    {
        // HashSet for unique policies
        private HashSet<Policy> policiesHashSet = new HashSet<Policy>();

        // LinkedHashSet for maintaining order of insertion
        private LinkedHashSet<Policy> policiesLinkedHashSet = new LinkedHashSet<Policy>();

        // SortedSet for sorting policies by expiry date
        private SortedSet<Policy> policiesSortedSet;

        public InsurancePolicyManagementSystem()
        {
            // SortedSet with custom comparer to sort by ExpiryDate
            policiesSortedSet = new SortedSet<Policy>(Comparer<Policy>.Create((x, y) => x.ExpiryDate.CompareTo(y.ExpiryDate)));
        }

        // Add Policy to all sets
        public void AddPolicy(Policy policy)
        {
            policiesHashSet.Add(policy);            // Add to HashSet (unique)
            policiesLinkedHashSet.Add(policy);      // Add to LinkedHashSet (maintains insertion order)
            policiesSortedSet.Add(policy);          // Add to SortedSet (sorted by expiry date)
        }

        // Get all unique policies
        public void GetAllPolicies()
        {
            Console.WriteLine("Unique Policies (HashSet):");
            foreach (var policy in policiesHashSet)
            {
                Console.WriteLine(policy);
            }
        }

        // Get policies expiring within the next 30 days
        public void GetPoliciesExpiringSoon()
        {
            DateTime today = DateTime.Today;
            DateTime soonExpiryDate = today.AddDays(30);

            Console.WriteLine("\nPolicies Expiring Soon (within the next 30 days):");
            foreach (var policy in policiesSortedSet)
            {
                if (policy.ExpiryDate <= soonExpiryDate)
                {
                    Console.WriteLine(policy);
                }
            }
        }

        // Get policies by a specific coverage type
        public void GetPoliciesByCoverageType(string coverageType)
        {
            Console.WriteLine($"\nPolicies with Coverage Type '{coverageType}':");
            foreach (var policy in policiesHashSet)
            {
                if (policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(policy);
                }
            }
        }

        // Get duplicate policies based on policy number (using a dictionary to count occurrences)
        public void GetDuplicatePolicies()
        {
            var policyCount = new Dictionary<string, int>();

            foreach (var policy in policiesHashSet)
            {
                if (policyCount.ContainsKey(policy.PolicyNumber))
                {
                    policyCount[policy.PolicyNumber]++;
                }
                else
                {
                    policyCount[policy.PolicyNumber] = 1;
                }
            }

            Console.WriteLine("\nDuplicate Policies (Based on Policy Number):");
            foreach (var entry in policyCount)
            {
                if (entry.Value > 1)
                {
                    Console.WriteLine($"Policy Number: {entry.Key} - Duplicate Count: {entry.Value}");
                }
            }
        }
    }

    class LinkedHashSet<T> : HashSet<T>
    {
        private LinkedList<T> order = new LinkedList<T>();

        public new bool Add(T item)
        {
            if (!Contains(item))
            {
                order.AddLast(item);
                base.Add(item);
                return true;
            }
            return false;
        }

        public new void Clear()
        {
            base.Clear();
            order.Clear();
        }

        public IEnumerable<T> GetOrderedItems()
        {
            foreach (var item in order)
            {
                yield return item;
            }
        }
    }

}

