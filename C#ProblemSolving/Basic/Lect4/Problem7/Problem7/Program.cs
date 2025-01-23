namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program to allow the user to enter int and print the REVERSED of it.

            Console.Write("Enter a number : ");
            int Number = int.Parse(Console.ReadLine() ?? "Enter a number");

            int ReverseNumber = 0; 

            while (Number > 0)   /// 123 ==>  
            {
                int reverselastnumber = Number % 10;   // get the last number
                ReverseNumber = (ReverseNumber * 10) + reverselastnumber;
                Number = Number / 10;   // remove last number
            }

            Console.WriteLine(ReverseNumber);
        }
    }
}
