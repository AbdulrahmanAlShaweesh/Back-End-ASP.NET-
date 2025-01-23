namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that takes two integers then prints the power.

            Console.Write("Enter The First Number : ");
            float.TryParse(Console.ReadLine(), out float FirstNumber);

            Console.Write("Enter The First Number : ");
            float.TryParse(Console.ReadLine(), out float SecondNumber);

            float result = (float) Math.Pow(FirstNumber , SecondNumber);

            Console.WriteLine($"The Power of {FirstNumber} and {SecondNumber} is {result}");

        }
    }
}
