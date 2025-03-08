using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign03.Classess
{
    public delegate string BookDelegate (Book book);

    public class LibraryClass
    {
        public static void ProcessBook(List<Book> books, BookDelegate fptr) {
            foreach (Book book in books)
            {
                Console.WriteLine(fptr.Invoke(book));
            }
        }
       
    

        public static void ProcessBook(List<Book> books, Func<Book, string> fptr) {

            foreach (var item in books)
            {
                Console.WriteLine(fptr(item));
            }
        } 
    }
}
