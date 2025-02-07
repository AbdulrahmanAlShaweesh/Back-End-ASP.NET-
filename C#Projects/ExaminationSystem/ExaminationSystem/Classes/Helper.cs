using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal static class Helper
    {
        public static void PrintSnakeSeparator(int length = 50)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(i % 3 == 0 ? 'o' : '-');
            }
            Console.WriteLine();
        }
    }
}
