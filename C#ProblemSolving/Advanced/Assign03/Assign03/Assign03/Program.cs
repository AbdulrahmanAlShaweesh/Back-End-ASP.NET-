using Advance_OOP_L03.Classes;

namespace Advance_OOP_L03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book("123-456", "C# Programming", new string[] { "Osamah Ebrahim", "Ahmed Ali" }, new DateTime(2025, 5, 1), 49.99m),
            new Book("789-012", "ASP.NET Core", new string[] { "Osamah Ebrahim", "Ahmed Ali" }, new DateTime(2025, 8, 15), 59.99m)
        };
            BookDelegate titleDelegate = new BookDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, titleDelegate);
        }
    }
}
