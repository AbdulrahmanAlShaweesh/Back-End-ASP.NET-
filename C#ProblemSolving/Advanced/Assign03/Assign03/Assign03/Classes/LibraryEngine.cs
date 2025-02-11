using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_OOP_L03.Classes
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> BList, BookDelegate fPtr)
        {
            foreach (Book B in BList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
