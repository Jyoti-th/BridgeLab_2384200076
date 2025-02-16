using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Linear_and_Binary_Search
{
    class CallingAllClass
    {
        //Reverse a String Using StringBuilder

        public void CallingReverseString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversedString = ReverseString.Reverse(input);

            Console.WriteLine("Reversed String: " + reversedString);
        }

        //Remove Duplicates from a String Using StringBuilder
        public void CallingRemoveDuplicates()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = RemoveDuplicates.RemoveDuplicateCharacters(input);

            Console.WriteLine("String after removing duplicates: " + result);

        }
        //Problem 1: Concatenate Strings Efficiently Using StringBuilder
        public void CallingConcatenateString()
        {
            string[] words = { "Hello", "this", "is", "a", "test" };

            string result = ConcatenateString.Concatenate(words);

            Console.WriteLine("Concatenated String: " + result);
        }

        // Compare StringBuilder Performance

        public void CallingCompare()
        {
            Console.Write("Enter number of iterations: ");
            int iterations = int.Parse(Console.ReadLine());

            ComparePerformance.Compare(iterations);
        }
        //Read a File Line by Line Using StreamReader
        public void CallingFile()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            ReadFile.ReadLineByLine(filePath);
        }

        //Count the Occurrence of a Word in a File Using StreamReader
        public void CallingWord()
        {

            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            Console.Write("Enter word to count: ");
            string wordToFind = Console.ReadLine();

            int result = WordCounter.CountWordOccurrences(filePath, wordToFind);

            if (result != -1)
            {
                Console.WriteLine($"The word '{wordToFind}' appears {result} times in the file.");
            }
        }

        //Convert Byte Stream to Character Stream Using StreamReader
        public void CallingConvertor()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            CharConvertor.ConvertByteStreamToCharStream(filePath);
        }

        //Read User Input and Write to File Using StreamReader
        public void CallingUserInput()
        {
            Console.Write("Enter file path to save input: ");
            string filePath = Console.ReadLine();

            ReadInput.WriteUserInputToFile(filePath);
        }

        //Linear Search
        public void CallingLinearSearchProgram()
        {
            Console.Write("Enter array elements separated by space: ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);  // Convert input to int array

            int firstNegative = LinearSearch.FindFirstNegative(arr);

            if (firstNegative != -1)
                Console.WriteLine($"First negative number: {firstNegative}");
            else
                Console.WriteLine("No negative number found in the array.");
        }

        //Search for a Specific Word in a List of Sentences
        public void CallingFindWord()
        {
            Console.Write("Enter the number of sentences: ");
        int n = int.Parse(Console.ReadLine());
        
        string[] sentences = new string[n];
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine();

        string result = SpecificWord.FindSentenceWithWord(sentences, word);

        if (result != "Not Found")
            Console.WriteLine($"First sentence containing '{word}': {result}");
        else
            Console.WriteLine("No sentence contains the given word.");
    }

        //Find the Rotation Point in a Rotated Sorted Array
        public void CallingFindRotationPoint()
        {
            Console.Write("Enter array elements (space-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            int rotationIndex = RotationPoint.FindRotationPoint(arr);
            Console.WriteLine($"Rotation Point (Index of Smallest Element): {rotationIndex}");
        
        }
        //
        public void CallingPeakElement()
        {
            Console.Write("Enter array elements (space-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            int peakIndex = PeakElement.FindPeakElement(arr);
            Console.WriteLine($"Index of Peak Element: {peakIndex}");
            Console.WriteLine($"Peak Element: {arr[peakIndex]}");
        }
        //Search for a Target Value in a 2D Sorted Matrix
        public void CallingSortedMatrix()
        {
            int[,] matrix = {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

            Console.Write("Enter target value to search: ");
            int target = int.Parse(Console.ReadLine());

            if (SortedMatrix.SearchMatrix(matrix, target, out int row, out int col))
            {
                Console.WriteLine($"Target found at position: ({row}, {col})");
            }
            else
            {
                Console.WriteLine("Target not found in the matrix.");
            }
        }
        //Find the First and Last Occurrence of an Element in a Sorted Array
        public void CallingOccurance()
        {
            Console.Write("Enter sorted array elements (space-separated): ");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            Console.Write("Enter target element: ");
            int target = int.Parse(Console.ReadLine());

            int firstIndex = Occurance.FindFirstOccurrence(arr, target);
            int lastIndex = Occurance.FindLastOccurrence(arr, target);

            if (firstIndex == -1)
            {
                Console.WriteLine("Element not found in the array.");
            }
            else
            {
                Console.WriteLine($"First occurrence index: {firstIndex}");
                Console.WriteLine($"Last occurrence index: {lastIndex}");
            }
        }
        //Challenge Problem (for both Linear and Binary Search)
        public void CallingSearchOperations()
        {
            int[] arr = { 3, 4, -1, 1, 2, 6 }; // Unsorted array
            Console.WriteLine("First Missing Positive: " + SearchOperations.FindFirstMissingPositive(arr));

            // Sorting the array for Binary Search
            Array.Sort(arr);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

            int target = 4;
            int index = SearchOperations.BinarySearch(arr, target);
            Console.WriteLine("Index of " + target + ": " + index);
        }
    }
}


    

