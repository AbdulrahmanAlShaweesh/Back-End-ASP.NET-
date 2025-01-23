using System.Runtime.Serialization.Formatters;

namespace Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program in C# Sharp to convert a decimal number into binary without using an array.

            int Number;
            bool flag; 

            do
            {
                Console.Write("Enter a Number : ");
                flag = int.TryParse(Console.ReadLine() , out Number);

            } while (!flag);

            string binarynumber = string.Empty; 

            while(Number > 0)
            {
                int remindar = Number % 2;             
                binarynumber = binarynumber + remindar;
                Number = Number / 2;
            }

            string BinaryNumber = string.Empty; 

            for (int i = binarynumber.Length - 1; i >= 0; i--) {
                BinaryNumber = BinaryNumber + binarynumber[i];
            }

            Console.WriteLine(BinaryNumber);
            #endregion
        }
    }
}
