namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
                13. 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
                    Example (1)
                    Input: 12 
                    Output: Yes
                    Example (2)
                    Input: 9 
                    Output: No
             */

            Console.WriteLine("Enter an interger number and will tell you if it can be divide by 3, and 4 or not? ");

            int Number = int.Parse( Console.ReadLine() ?? "1");

            var result = (Number % 3 == 0 && Number % 4 == 0) ? "Yes" : "No";

            Console.WriteLine(result);
        }   
    }
}
