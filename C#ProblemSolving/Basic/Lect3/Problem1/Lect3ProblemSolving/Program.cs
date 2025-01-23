namespace Lect3ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            DisplayGreetingsPatterin();
            Console.WriteLine("Welcome to My Assignment 3 Problem Solving");
            Console.WriteLine($"{new string('*', 50)}");
            Console.WriteLine("\n\n\n");


            // 1. Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Please Enter a number");
            var UserInput = Console.ReadLine() ?? "Please Enter a number";
            Console.WriteLine($"The number You entered is {UserInput}");
        }

        static void DisplayGreetingsPatterin()
        {
        Console.WriteLine(new string('*', 50));
        Console.WriteLine($"*{new string(' ', 48)}*");
        Console.WriteLine($"*{new string(' ' , 9)} My Lect 3 Assignment Console {new string(' ', 9)}*");
        Console.WriteLine($"*{new string(' ', 48)}*");
        Console.WriteLine($"{new string('*', 50)}");
        }
    }
}
