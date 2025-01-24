using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign04.Classes
{
    internal class Complex
    {
        #region Properities
        private int real { get; set; }
        private int imaginary { get; set; }

        public int Real
        {
            get { return real; }
            set { real = value;}
        }

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
        #endregion

        #region Methods
        public static Complex operator + (Complex left , Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) + (right?.real ?? 0), 
                imaginary = (left?.imaginary ?? 0) + (right?.imaginary ?? 0)
            };
        }

        public static Complex operator - (Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) - (right?.real ?? 0),
                imaginary = (left?.real ?? 0) - (right?.real ?? 0)
            };
        }

        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
        #endregion
    }
}
