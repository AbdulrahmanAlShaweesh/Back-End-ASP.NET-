namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            int[] Array1 = { 1, 2, 3, 4, 5 };
            int[] Array2 = { 6, 7, 8, 9, 10 };

            int[] MeagedArray = new int[Array1.Length * 2];
       

            for (int i = 0; i < Array1.Length; i++) { 
                
                MeagedArray[i] = Array1[i];
            }

            int counter = 0; 

            for (int i = 5; i < Array1.Length *2; i++)
            {
                MeagedArray[i] = Array2[counter];
                counter++;
            }

            foreach (int i in MeagedArray) { 
                Console.WriteLine(i);
            }

            #endregion
        }
    }
}
