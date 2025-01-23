namespace Problem15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program in C# Sharp to find maximum and minimum element in an array

            int[] numbers = { 15, 42, 7, 89, 23, 5, 64 };

            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

        
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);

        }
    }
}
