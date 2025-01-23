namespace Problem15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 15. Write a program that allows the user to insert an integer number then check If a number is even or odd.


            Console.WriteLine("Enter a number? ");
            float number = float.Parse(Console.ReadLine() ?? "");


            Console.WriteLine("\nUsing Ternary Condition");
            // using ternary condition
            var result = number % 2 == 0 ? $"The number {number} is even number" : $"The number {number} is odd number";
            Console.WriteLine(result);

            // using if condition 
            Console.WriteLine("\nUsing if Condition");
            if (number % 2 == 0) { Console.WriteLine($"The number {number} is even number"); }
            else { Console.WriteLine($"The number {number} is odd number"); }

            // using Switch case
            Console.WriteLine("\nUsing Switch case");
            switch(number % 2)
            {
                case 0:
                    Console.WriteLine($"The number {number} is an even number.");
                    break;

                case 1:
                case -1:
                    Console.WriteLine($"The number {number} is an odd number"); 
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
