namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program to allow the user to enter a string and print the REVERSE of it.

            Console.Write("Enter a text : ");
            string text = Console.ReadLine();

            string ReverseString = "";

            for(int i = text.Length - 1; i >= 0; i--)  // using for loop
            {
                ReverseString += text[i];  
            }

            Console.Write(ReverseString);

            // using reverse build-in method
            Console.WriteLine(text.Reverse());
        }
    }
}
