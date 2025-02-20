using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class InvertMap
    {
        public static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> originalDict)
        {
            // Create a new dictionary to store inverted key-value pairs
            Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

            // Loop through each key-value pair in the original dictionary
            foreach (var pair in originalDict)
            {
                V value = pair.Value;
                K key = pair.Key;

                // If the value already exists in the inverted dictionary, add the key to the list
                if (invertedDict.ContainsKey(value))
                {
                    invertedDict[value].Add(key);
                }
                else
                {
                    // Otherwise, create a new list with the current key
                    invertedDict[value] = new List<K> { key };
                }
            }

            return invertedDict;
        }

    }
}
