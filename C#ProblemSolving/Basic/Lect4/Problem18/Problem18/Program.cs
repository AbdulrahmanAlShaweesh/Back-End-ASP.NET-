namespace Problem18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a space-separated list of words:");
            string input = Console.ReadLine();

             
            string reversedWords = "";

             
            string currentWord = "";

             
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currentChar = input[i];

                if (currentChar != ' ')  
                {
                    currentWord = currentChar + currentWord;
                }
                else if (currentWord != "")  
                {
                    reversedWords += currentWord + " ";
                    currentWord = "";   
                }
            }

            
            if (currentWord != "")
            {
                reversedWords += currentWord;
            }

           
            Console.WriteLine(reversedWords);
        }
    }
}
