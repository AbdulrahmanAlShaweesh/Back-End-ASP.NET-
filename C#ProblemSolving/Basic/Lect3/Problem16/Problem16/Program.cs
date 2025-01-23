namespace Problem16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                16. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) 
                    otherwise print (consonant).
                    Example (1)
                    Input: O
                    Output: vowel
                    Example (2)
                    Input: b
                    Output: Consonant
             */

            Console.WriteLine("Enter a letter and will tell you if it is constant or vowel letter");
            string letter = Console.ReadLine()!.ToLower() ?? "Enter a valid number";

            // using ternary operator
            Console.WriteLine("\nUsing ternary conition");
            string message = letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" ? "vowel" : "consonant";
            Console.WriteLine(message);


            // using if else condition
            Console.WriteLine("\nUsing if else conditioon");
            if(letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u") { Console.WriteLine("vowel"); }
            else { Console.WriteLine("consonant"); }

            // using Switch case
            Console.WriteLine("\nUsing Switch case statement");
            switch (letter)
            {
                case "a" : Console.WriteLine("vowel"); break;
                case "e" : Console.WriteLine("vowel"); break;
                case "i" : Console.WriteLine("vowel"); break;
                case "o" : Console.WriteLine("vowel"); break; 
                case "u" : Console.WriteLine("vowel"); break;
                default: Console.WriteLine("consonant"); break;
            }

        }
    }
}
