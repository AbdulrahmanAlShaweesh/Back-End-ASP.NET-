using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //    Note: The formula for simple interest is Interest = (principal * rate * time) / 100.

            Console.WriteLine("Enoter the Principal Amount ?");
            var amount = float.TryParse(Console.ReadLine(), out float amounts);

            Console.WriteLine("Enter the amount of interest? ");
            var rateAetAmount = float.TryParse(Console.ReadLine(), out float rates);

            Console.WriteLine("Enter the time ? "); 
            var time = float.TryParse(Console.ReadLine(), out float times);

            var interstAmount = (amounts * rates * times) / 100;

            Console.WriteLine($"The Inerset amount is {interstAmount:c}");

        }
    }
}
