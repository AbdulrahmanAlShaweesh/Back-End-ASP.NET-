using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.Write("Enter the start number : ");
            int StartNumber = int.Parse(Console.ReadLine() ?? "Enter Int Number");

            Console.Write("Enter the End Number : ");
            int EndNumber = int.Parse(Console.ReadLine() ?? "Enter Int Number"); ;
            int[] primeNumbers = [];
            bool flag = true;

            for (int i = StartNumber; i <= EndNumber; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) 
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    Console.Write($"{i}  ");
                }

                flag = true;
            }
            #endregion
        }
    }
}
