namespace Problem17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Consider an Array of Integer values with size N, having values as    
            // in this Example 7 , 0 , 0 , 0 , 0 , 5 , 6 , 7 , 5 0 , 7 , 5 , 3

            Console.Write("Enter the size of the array (N): ");
            int n = int.Parse(Console.ReadLine() ?? "Enter the ArraySize");

            
            Console.WriteLine("Enter the array elements:");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine() ?? "Enter a valid element");
            }

            
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();

            int longestDistance = 0;

            
            for (int i = 0; i < n; i++)
            {
                if (firstOccurrence.ContainsKey(array[i]))
                {
                    
                    int distance = i - firstOccurrence[array[i]];
                    if (distance > longestDistance)
                    {
                        longestDistance = distance;
                    }
                }
                else
                {
                    
                    firstOccurrence[array[i]] = i;
                }
            }

            Console.WriteLine("The longest distance between two equal cells is: " + longestDistance);

        }
    }
}
