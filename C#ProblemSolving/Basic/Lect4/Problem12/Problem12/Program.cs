namespace Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program in C# Sharp to find the sum of all elements of the array.
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            foreach (int num in Numbers) {
                sum += num;
            }

            Console.WriteLine($"The Sum of the array is {sum}");
            #endregion
        }
    }
}
