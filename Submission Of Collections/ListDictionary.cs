using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class ListDictionary
    {
       public static Dictionary<string, int> CountFrequencies(List<string> words)
        {
            Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (frequencyDict.ContainsKey(word))
                    frequencyDict[word]++;
                else
                    frequencyDict[word] = 1;
            }

            return frequencyDict;
        }
    }
}
