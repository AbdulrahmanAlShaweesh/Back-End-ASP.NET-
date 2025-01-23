namespace Problem16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program in C# Sharp to find the second largest element in an array.
            int[] numbers = { 15, 42, 7, 89, 23, 5, 64 };

            if (numbers.Length < 2)
            {
                Console.WriteLine("Array must have at least two elements.");
                return;
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    // Update second largest before updating largest
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    // Update second largest if it's greater than current second largest
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("No second largest element exists.");
            }
            else
            {
                Console.WriteLine("The second largest element is: " + secondLargest);
            }
        }
    }
}
