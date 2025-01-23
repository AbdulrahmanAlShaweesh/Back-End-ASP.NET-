namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that allows the user to insert an integer then 
            // print a multiplication table up to 12.

            Console.Write("Write an Number and will display multiplication up to table 12 ? ");
            int.TryParse(Console.ReadLine(), out int tableNumber);

            for (int outer = tableNumber; outer <= 12; outer++) { 
                Console.WriteLine($"{new string('*', 25)} Table {outer} {new string('*', 25)}");

                for(int innter = 1; innter <= 12; innter++) {
                    int table = outer * innter;

                    Console.WriteLine($"{outer} X {innter} = {table}");
                }
            }

        }
    }
}
