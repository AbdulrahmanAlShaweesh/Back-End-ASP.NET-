namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
                 Example (1)
                 Input:7,8,5
                 Output:
                 max element = 8
                 min element = 5
             —--------------------------------
                 Example (2)
                 Input: 3 6 9
                 Outputs:
                 Max element = 9
                 Min element = 3
             */

            Console.WriteLine("Enter The First Number? ");
            int number1 = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine("Enter the Second Number");
            int number2 = int.Parse(Console.ReadLine() ?? "2"); 

            Console.WriteLine("Enter The Third Number");
            int number3 = int.Parse(Console.ReadLine() ?? "3");

            int max, min;

            // deterimne the max number
            if (number1 >= number2 && number1 >= number3) { max = number1; }
            else if (number2 >= number1 && number2 >= number3) { max = number2; }
            else { max = number3; }

            // deterime the min number 
            if (number1 <= number2 && number1 <= number3) { min = number1; }
            else if (number2 <= number1 && number2 <= number3) { min = number2; }
            else {  min = number3; }

            Console.WriteLine($"Max number is {max}");
            Console.WriteLine($"Min number is {min}\n");

            Console.WriteLine("Uisng Max, and Min Build in Methods");
            // using Max and min methods
            Console.WriteLine($"Max number is {Math.Max(number1 , Math.Max(number2 , number3))}");
            Console.WriteLine($"Min number is {Math.Min(number1 , Math.Min(number2 , number3))}");

        }
    }
}
