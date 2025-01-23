namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write C# program that Extract a substring from a given string.
            Console.WriteLine("Please Enter Your Full Name ? ");

            var Name = Console.ReadLine() ?? "Enter Your Name";

            Console.WriteLine(Name);

            var result = Name.Length > 6 ? Name.Substring(1, 5) : "Name Most Contains More Than 6 Charachters";
            Console.WriteLine(result);
        }
    }
}
