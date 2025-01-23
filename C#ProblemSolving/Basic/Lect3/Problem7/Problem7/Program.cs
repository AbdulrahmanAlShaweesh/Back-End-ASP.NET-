namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Write C# program that take two string variables and print them as one variable 

            Console.WriteLine("Please Enter The First Test"); 
            var text1 = Console.ReadLine();

            Console.WriteLine("Please Enter the Second Text");
            var text2 = Console.ReadLine();

            var fullText = string.Concat(text1, " " , text2);    // using string concation meth
            Console.WriteLine(fullText);

            // or we can use + operator
            Console.WriteLine(text1 + " " + text2);

            // or we can use string formating 
            Console.WriteLine($"{text1} {text2}");

        }
    }
}
