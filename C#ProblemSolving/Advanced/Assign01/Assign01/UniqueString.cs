using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal class UniqueString<T> where T : IEquatable<T>, IComparable<T>
    {
        public int FindFirstUniqueIndex(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1; // Return -1 for empty or null strings

            Dictionary<T, int> charCount = new Dictionary<T, int>();
            Dictionary<T, int> charIndex = new Dictionary<T, int>();

           // Count occurrences and track first appearance
            for (int i = 0; i < input.Length; i++)
            {
                T character = (T)(object)input[i]; // Explicit casting to generic type

                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    charCount[character] = 1;
                    charIndex[character] = i;
                }
            }

            // Step 2: Find the first character with count 1
            foreach (var ch in charIndex)
            {
                if (charCount[ch.Key] == 1)
                    return ch.Value; // Return the first non-repeated character's index
            }

            return -1;  
        }
    }
}
