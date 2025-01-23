namespace Problem19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine() ?? "Enter a valud row number");

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine() ?? "Enter a valid col number");

            int[,] array1 = new int[rows, columns];
            int[,] array2 = new int[rows, columns];


            Console.WriteLine("Enter the elements for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element at position ({i}, {j}): ");
                    array1[i, j] = int.Parse(Console.ReadLine() ?? "Enter the index of the element");
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2[i, j] = array1[i, j];
                }
            }

            Console.WriteLine("\nSecond array after copying elements from the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();  

            }
        }
    }
}
