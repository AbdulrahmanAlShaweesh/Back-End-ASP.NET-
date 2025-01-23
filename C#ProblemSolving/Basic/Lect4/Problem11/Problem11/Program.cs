namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints an identity matrix using for loop,
            // in other words takes a value n from the user and shows the identity table of size n * n

            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine() ?? "Enter a number");

            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    if(i == j)
                    {
                        Console.Write("1 ");
                    }else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
