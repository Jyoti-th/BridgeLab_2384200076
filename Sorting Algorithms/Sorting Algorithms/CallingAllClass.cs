using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class CallingAllClass
    {
        public void CallingBubbleSort()
        {
            // Sample array of student marks
            int[] marks = { 45, 78, 12, 89, 34, 67 };

            Console.WriteLine("Original marks:");
            BubbleSort.PrintArray(marks);

            // Sorting the array
            BubbleSort.SortMarks(marks);

            Console.WriteLine("Sorted marks:");
            BubbleSort.PrintArray(marks);
        }

        public void InsertionSortProgram()
        {
            // Sample array of employee IDs
            int[] empIDs = { 105, 102, 109, 101, 108, 103 };

            Console.WriteLine("Original Employee IDs:");
            InsertionSort.PrintArray(empIDs);

            // Sorting the array
            InsertionSort.SortEmployeeIDs(empIDs);

            Console.WriteLine("Sorted Employee IDs:");
            InsertionSort.PrintArray(empIDs);
        }

        public void MergeSortProgram()
        {
        
            Console.WriteLine("Enter the number of books:");
            int size = Convert.ToInt32(Console.ReadLine()); // Take user input for array size

            int[] prices = new int[size]; // Create an array of given size

            // Taking input for book prices
            Console.WriteLine("Enter the prices of books:");
            for (int i = 0; i < size; i++)
            {
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Book Prices:");
            MergeSort.PrintArray(prices);

            // Sorting the book prices using Merge Sort
            MergeSort.SortBookPrices(prices, 0, prices.Length - 1);

            Console.WriteLine("\nSorted Book Prices:");
            MergeSort.PrintArray(prices);
        }

        public void CallingQuickSortProgram()
        {
            Console.WriteLine("Enter the number of products:");
            int size = Convert.ToInt32(Console.ReadLine()); // Take user input for array size

            int[] prices = new int[size]; // Create an array of given size

            // Taking input for product prices
            Console.WriteLine("Enter the prices of products:");
            for (int i = 0; i < size; i++)
            {
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Product Prices:");
            QuickSort.PrintArray(prices);

            // Sorting the product prices using Quick Sort
            QuickSort.SortProductPrices(prices, 0, prices.Length - 1);

            Console.WriteLine("\nSorted Product Prices:");
            QuickSort.PrintArray(prices);
        }

        public void CallingSelectionSortProgram()
        {
            Console.WriteLine("Enter the number of exam scores:");
            int size = Convert.ToInt32(Console.ReadLine()); // Take user input for array size

            int[] scores = new int[size]; // Create an array of given size

            // Taking input for exam scores
            Console.WriteLine("Enter the exam scores:");
            for (int i = 0; i < size; i++)
            {
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            SelectionSort sorter = new SelectionSort(); // Create an object of SelectionSort class

            Console.WriteLine("\nOriginal Exam Scores:");
            sorter.PrintArray(scores); // Print original scores

            // Sorting the exam scores using Selection Sort
            sorter.SortExamScores(scores);

            Console.WriteLine("\nSorted Exam Scores:");
            sorter.PrintArray(scores); // Print sorted scores
        }

        public void CallingHeapSortProgram()
        {
            Console.WriteLine("Enter the number of employee salaries:");
            int size = Convert.ToInt32(Console.ReadLine()); // Take user input for array size

            int[] salaries = new int[size]; // Create an array of given size

            // Taking input for salaries
            Console.WriteLine("Enter the employee salaries:");
            for (int i = 0; i < size; i++)
            {
                salaries[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Salaries:");
            HeapSort sorter = new HeapSort();
            sorter.PrintArray(salaries); // Print original salaries

            // Sorting the salaries using Heap Sort
            sorter.SortSalaries(salaries);

            Console.WriteLine("\nSorted Salaries:");
            sorter.PrintArray(salaries); // Print sorted salaries
        }
        public void CallingCountingSortProgram()
        {
            Console.WriteLine("Enter the number of students:");
            int size = Convert.ToInt32(Console.ReadLine()); // Take user input for array size

            int[] ages = new int[size]; // Create an array of given size

            Console.WriteLine("Enter the ages of students:");
            for (int i = 0; i < size; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine()); // Taking age input
            }

            Console.WriteLine("\nOriginal Ages:");
            CountingSort sorter = new CountingSort();
            sorter.PrintArray(ages); // Print original ages

            // Sorting the ages using Counting Sort
            int minAge = 10, maxAge = 18; // Assuming student ages are between 10 and 18
            sorter.SortStudentAges(ages, minAge, maxAge);

            Console.WriteLine("\nSorted Ages:");
            sorter.PrintArray(ages); // Print sorted ages
        }
    }
}
