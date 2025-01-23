using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment03.Classes
{
    internal class Book
    {

        #region Properites
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string IsBN { get; set; } 
        #endregion

        #region Constructor
        public Book(string? title, string? author, string isBN)
        {
            Title = title;
            Author = author;
            IsBN = isBN;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Title {Title}\nAuthor {Author}\nISNB {IsBN}";
        }
        #endregion
    }
}
