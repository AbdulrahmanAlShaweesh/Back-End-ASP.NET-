namespace Problem17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                17. Write a program to input the month number and print the number of days in that month.
                Example
                Input: Month Number: 1
                Output: Days in Month: 31
            */

            Console.WriteLine("Enter Month Number? ");
            int monthNumber = Convert.ToInt32(Console.ReadLine() ?? "");

            if (monthNumber >= 1 && monthNumber <= 12)
            {
                if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12) 
                { 
                    Console.WriteLine($"Days in Month {monthNumber} is 31 days"); 
                }else if(monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 1)
                {
                    Console.WriteLine($"Days in Month {monthNumber} is 30 days");
                }else if(monthNumber == 2)
                {
                    Console.WriteLine("Is it a leap year (Y-N)? ");
                    string isLeapYear = Console.ReadLine()!.ToUpper() ?? "";

                    int message = (isLeapYear == "Y") ? monthNumber = 29 : monthNumber = 28;
                    Console.WriteLine($"Days in Month {monthNumber} is {message} Days");
                }

            }else { Console.WriteLine("Invalid Month Number"); }
        }
    }
}
