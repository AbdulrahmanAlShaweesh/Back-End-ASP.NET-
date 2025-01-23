using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment03.Classes
{
    internal class PrintedBook : Book
    {
        #region Properity
        public int PageCount { get; set; }
        #endregion

        #region Constructor
        public PrintedBook(string title, string author, string isBN, int pageCount) : base(title, author, isBN)
        {
            PageCount = pageCount;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return base.ToString() + $" Page count is : {PageCount}"; 
        }
        #endregion

    }
}
