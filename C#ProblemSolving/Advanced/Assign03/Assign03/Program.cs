using Assign03.Classess;

namespace Assign03
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<Book> books = new List<Book>()
             {
                 new Book("1", "C++", ["Mohammed", "Sara", "Marwa"], DateTime.Now, 32),
                 new Book("2", "Python", ["Nada", "Sager", "Ahmed"], DateTime.Now, 21),
                 new Book("3", "C#", ["Abdulrahman", "Samar", "Nermin"], DateTime.Now, 32),
                 new Book("4", "Javascript", ["Tom", "Jack", "POB"], DateTime.Now, 32),
             };

            BookDelegate BookTitle = BookFunctions.GetTitle;
            BookDelegate BookPrice = BookFunctions.GetPrice;
            BookDelegate BookAuthors = BookFunctions.GetAuthor;

            LibraryClass.ProcessBook(books, BookTitle);
            Console.WriteLine("------------------------------------------------");
            LibraryClass.ProcessBook(books, BookPrice);
            Console.WriteLine("------------------------------------------------");
            LibraryClass.ProcessBook(books, BookAuthors);
        }
    }
}
