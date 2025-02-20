using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class ExecutionClass
    {
        public void CallingReverseList()
        {
            // ArrayList example
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList: " + string.Join(", ", arrayList.ToArray()));
            ReverseList.ReverseArrayList(arrayList);
            Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList.ToArray()));

            // LinkedList example
            LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Original LinkedList: " + string.Join(", ", linkedList));
            linkedList = ReverseList.ReverseLinkedList(linkedList);
            Console.WriteLine("Reversed LinkedList: " + string.Join(", ", linkedList));
        }

        public void CallingRotateList()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            int rotateBy = 2;

            List<int> rotatedList = RotateUsingList.RotateList(numbers, rotateBy);
            Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
        }

        public void CallingListDictionary()
        {
            List<string> words = new List<string> { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> frequencies = ListDictionary.CountFrequencies(words);

            foreach (var kvp in frequencies)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public void CallingRemoveDuplicates()
        {
            List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };
            List<int> uniqueList = RemoveOrderDuplicates.RemoveDuplicates(numbers);
            Console.WriteLine("List after removing duplicates: " + string.Join(", ", uniqueList));
        }

        public void CallingNthEnd()
        {
            LinkedList<string> linkedList = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
            int n = 2;

            string result = NthEnd.FindNthFromEnd(linkedList, n);
            Console.WriteLine("Nth element from the end: " + result);
        }

        public void CallingSetEqual()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

            bool result = SetEqual.AreSetsEqual(set1, set2);
            Console.WriteLine(result);
        }

        public void CallingUnionIntersection()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Creating object of SetOperations
            UnionIntersection operations = new UnionIntersection(set1, set2);

            // Calling methods
            HashSet<int> unionResult = operations.ComputeUnion();
            HashSet<int> intersectionResult = operations.ComputeIntersection();

            // Displaying results
            Console.WriteLine("Union: { " + string.Join(", ", unionResult) + " }");
            Console.WriteLine("Intersection: { " + string.Join(", ", intersectionResult) + " }");
        }

        public void CallingSymmetricDifference()
        {


            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Creating object of SetOperations
            SymmetricDifference operations = new SymmetricDifference(set1, set2);

            // Calling method
            HashSet<int> symmetricDifferenceResult = operations.ComputeSymmetricDifference();

            // Displaying result
            Console.WriteLine("Symmetric Difference: { " + string.Join(", ", symmetricDifferenceResult) + " }");
        }
        public void CallingSortedList()
        {
            HashSet<int> numbers = new HashSet<int> { 5, 3, 9, 1 };
            List<int> sortedList = SortedList.ConvertToSortedList(numbers);

            Console.WriteLine("Sorted List: [ " + string.Join(", ", sortedList) + " ]");
        }

        public void CallingReverseQueue()
        {
            // Create and populate the queue with example elements
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Original Queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Reverse the queue using the recursive method
            ReverseQueue.ReverseQueueUsingRecursion(queue);

            Console.WriteLine("\nReversed Queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void CallingGenerateNumber()
        {
            // Input: N (the number of binary numbers to generate)
            int N = 5;

            // Generate the binary numbers using the queue
            List<string> binaryNumbers = BinaryNumbers.GenerateBinaryNumbersUsingQueue(N);

            // Output the generated binary numbers
            Console.WriteLine("The first " + N + " binary numbers are:");
            foreach (string binary in binaryNumbers)
            {
                Console.WriteLine(binary);
            }
        }
        public void CallingHospitalHeritage()
        {
            HospitalTriage triage = new HospitalTriage();
            triage.AddPatient("John", 3);
            triage.AddPatient("Alice", 5);
            triage.AddPatient("Bob", 2);

            Console.WriteLine("\n--- Treating Patients ---");
            triage.TreatPatient();
            triage.TreatPatient();
            triage.TreatPatient();
        }

        public void CallingWordFrequency()
        {
            // Specify the path of the text file (change this to the path of your file)
            string filePath = "sample.txt";

            // Count word frequencies from the file
            Dictionary<string, int> wordCount = WordFrequencyCounter.CountWordFrequencies(filePath);

            // Display the word frequencies
            WordFrequencyCounter.DisplayWordFrequencies(wordCount);
        }

        public void CallingInvertMap()
        {
            // Example input dictionary
            Dictionary<string, int> originalDict = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            // Inverting the dictionary
            var invertedDict = InvertMap.InvertDictionary(originalDict);

            // Display the inverted dictionary
            Console.WriteLine("Inverted Dictionary:");
            foreach (var pair in invertedDict)
            {
                Console.WriteLine($"{pair.Key} = [{string.Join(", ", pair.Value)}]");
            }
        }

        public void CallingInsurancePolicy()
        {
            var system = new InsurancePolicyManagementSystem();

            // Adding some policies
            system.AddPolicy(new Policy("P001", "John Doe", "Health", new DateTime(2020, 1, 1), new DateTime(2025, 1, 1), 1200.50m));
            system.AddPolicy(new Policy("P002", "Jane Smith", "Car", new DateTime(2021, 3, 1), new DateTime(2024, 3, 1), 800.75m));
            system.AddPolicy(new Policy("P003", "Alice Johnson", "Home", new DateTime(2022, 5, 15), new DateTime(2023, 5, 15), 1500.00m));
            system.AddPolicy(new Policy("P004", "Bob Brown", "Health", new DateTime(2023, 6, 1), new DateTime(2024, 6, 1), 1100.25m));
            system.AddPolicy(new Policy("P001", "John Doe", "Health", new DateTime(2020, 1, 1), new DateTime(2025, 1, 1), 1200.50m)); // Duplicate

            // Retrieve all unique policies
            system.GetAllPolicies();

            // Retrieve policies expiring soon (within the next 30 days)
            system.GetPoliciesExpiringSoon();

            // Retrieve policies with a specific coverage type
            system.GetPoliciesByCoverageType("Health");

            // Retrieve duplicate policies based on policy numbers
            system.GetDuplicatePolicies();
        }

        public void CallingVotingSystem()
        {
            VotingSystem votingSystem = new VotingSystem();

            // Voting for candidates
            votingSystem.Vote("Alice");
            votingSystem.Vote("Bob");
            votingSystem.Vote("Alice");
            votingSystem.Vote("Charlie");
            votingSystem.Vote("Bob");
            votingSystem.Vote("Alice");

            // Displaying the results
            votingSystem.DisplayVotesDictionary();
            votingSystem.DisplaySortedVotes();
            votingSystem.DisplayLinkedVotes();
        }
        
        public void CallingShoppingCart()
        {
            ShoppingCart cart = new ShoppingCart();

            // Adding products to the cart
            cart.AddProduct("Laptop", 1200.50);
            cart.AddProduct("Headphones", 150.75);
            cart.AddProduct("Smartphone", 899.99);
            cart.AddProduct("Keyboard", 89.99);
            cart.AddProduct("Mouse", 25.50);

            // Display products in different formats
            cart.DisplayProductsDictionary();
            cart.DisplayOrderedProducts();
            cart.DisplaySortedProducts();

            // Calculate and display the total price of the cart
            double total = cart.GetTotalPrice();
            Console.WriteLine($"\nTotal price of products in cart: ${total:F2}");
        }

        public void CallingBankingSystem()
        {
            BankingSystem bankingSystem = new BankingSystem();

            // Create some accounts
            bankingSystem.CreateAccount(101, 500.00);
            bankingSystem.CreateAccount(102, 1500.00);
            bankingSystem.CreateAccount(103, 300.00);

            // Display all accounts (unsorted)
            bankingSystem.DisplayAllAccounts();

            // Deposit into accounts
            bankingSystem.Deposit(101, 200.00);
            bankingSystem.Deposit(102, 500.00);
            bankingSystem.Deposit(103, 100.00);

            // Display accounts sorted by balance
            bankingSystem.DisplaySortedAccounts();

            // Request withdrawals
            bankingSystem.RequestWithdrawal(101, 100.00);
            bankingSystem.RequestWithdrawal(102, 2500.00); // Insufficient balance
            bankingSystem.RequestWithdrawal(103, 50.00);

            // Process withdrawals
            bankingSystem.ProcessWithdrawals();

            // Display accounts after withdrawals
            bankingSystem.DisplaySortedAccounts();
        }

        public void CallingSuperset()
        {
            HashSet<int> set1 = new HashSet<int> { 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

            bool result = SubSet.IsSubset(set1, set2);
            Console.WriteLine("Is subset? " + result);
        }
    }
    }





