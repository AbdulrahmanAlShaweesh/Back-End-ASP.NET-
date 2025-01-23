using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssignment03.Classes
{
    internal class HireDate
    {

        #region Propeities
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; } 
        #endregion

        #region Constructor
        public HireDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{day:D2}/{month:d2}/{year}";
        }
        #endregion


    }
}
