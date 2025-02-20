using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Streams
{
    class CountWords
    {
  
            public static void Counter()
            {
                string filePath = @"C:\Users\JYOTI THAKUR\Desktop\article.txt"; // Change this to  actual file path

                try
                {
                    Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)  // Read line by line
                        {
                            string[] words = Regex.Split(line.ToLower(), @"\W+"); // Split words using regex (ignores punctuation)

                            foreach (string word in words)
                            {
                                if (!string.IsNullOrWhiteSpace(word))  // Ignore empty words
                                {
                                    if (wordCount.ContainsKey(word))
                                        wordCount[word]++;
                                    else
                                        wordCount[word] = 1;
                                }
                            }
                        }
                    }

                    // Total words count
                    int totalWords = wordCount.Values.Sum();
                    Console.WriteLine($"Total Words in File: {totalWords}\n");

                    // Get top 5 frequent words
                    var topWords = wordCount.OrderByDescending(kv => kv.Value).Take(5);

                    Console.WriteLine(" Top 5 Most Frequent Words:");
                    foreach (var word in topWords)
                    {
                        Console.WriteLine($"{word.Key}: {word.Value} times");
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(" IOException: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Error: " + ex.Message);
                }
            }
        }
    }


