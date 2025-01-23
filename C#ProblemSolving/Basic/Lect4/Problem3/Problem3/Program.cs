namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that allows to user to insert number then print all even numbers between 1 to this number

            Console.Write("Write a number and will print the even number between 1 and Your Number ? ");
            int.TryParse(Console.ReadLine(), out var UserInput);

            for(int i = 0; i < UserInput; i++)
            {
               if(i % 2 == 0) Console.WriteLine(i);
            }
        }
    }
}
