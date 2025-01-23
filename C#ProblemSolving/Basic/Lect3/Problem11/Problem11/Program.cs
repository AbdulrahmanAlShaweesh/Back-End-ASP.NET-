namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 11. 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
                 Ex :
                 Today’s date : 20 , 11 , 2001
                 Today's date : 20 / 11 / 2001
                 Today's date : 20 – 11 – 2001
             */

            Console.WriteLine("Enter the day in a number? ");
            int day = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine("Enter the Month in a number?");
            int month = int.Parse(Console.ReadLine() ?? "1");

            Console.WriteLine("Enter the year in a number? ");
            int year = int.Parse(Console.ReadLine() ?? "1");

            DateTime Dates = new DateTime(year , month , day);

            Console.WriteLine($"The date is {Dates:dd,MM,yyy}");
            Console.WriteLine($"The date is {Dates:dd/MM/yyy}");
            Console.WriteLine($"The date is {Dates:dd-MM-yyy}");
        }
    }
}
