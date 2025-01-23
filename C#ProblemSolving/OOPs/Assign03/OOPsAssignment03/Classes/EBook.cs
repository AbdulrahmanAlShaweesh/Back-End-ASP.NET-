using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment03.Classes
{
    internal class EBook : Book
    {
        #region Properity
        public double FileSize { get; set; }
        #endregion

        #region Constructor
        public EBook(string title, string author, string isBN, double fileSize)
            : base(title, author, isBN)
        {
            FileSize = fileSize;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + $"\nFile Size : {FileSize} MB";
        }
        #endregion
    }
}
