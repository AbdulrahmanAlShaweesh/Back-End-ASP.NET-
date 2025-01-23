namespace Problem20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a Program to Print One Dimensional Array in Reverse Order
            string[] Names = {"Monahmed", "Ahmed" ,"Omar" , "Sara"};

            string[] reverseOrderArray = new string[Names.Length];

            int index = 0;

            for (int i = Names.Length - 1; i >= 0; i--)
            {
                reverseOrderArray[index] = Names[i];
                index++;
            }

            foreach (string i in reverseOrderArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
