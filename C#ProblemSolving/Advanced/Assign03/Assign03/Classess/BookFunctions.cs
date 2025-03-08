using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign03.Classess
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if(book is not null)
            {
                return $"Title = {book.Title}";
            }
            return "Book Not Found";
        }

        public static string GetAuthor(Book book)
        {
            if (book is not null)
            {
                string author = "";

                for (int i = 0; i < book.Authors.Length; i++)
                {
                    author += book.Authors[i];
                }
                return $"Author = {author}";
            }
            return "Not Found";
        }

        public static string GetPrice(Book book) { 
            if(book is not null)
            {
                return $"Price = {book.Price}";
            }

            return "Not Found";
        }
    }
}
