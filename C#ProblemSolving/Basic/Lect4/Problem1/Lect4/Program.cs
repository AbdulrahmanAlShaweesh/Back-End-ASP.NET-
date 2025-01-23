namespace Lect4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            Console.Write("Enter an Number and will let you know all the numbers between it ? ");
            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine($"The Numbers between 1 - {number}");
        

            for (int i = 2; i < number; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
