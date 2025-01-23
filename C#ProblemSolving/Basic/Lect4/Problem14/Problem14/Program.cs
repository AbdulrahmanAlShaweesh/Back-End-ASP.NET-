using System;

namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Write a program in C# Sharp to count the frequency of each element of an array.
            int[] numbers = { 4, 2, 4, 5, 2, 3, 4, 2, 1 };
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            Console.WriteLine("Frequency of each element in the array:");
            foreach (var item in frequency)
            {
                Console.WriteLine($"Element {item.Key} occurs {item.Value} times");
            }

            #endregion
        }
    }
}
