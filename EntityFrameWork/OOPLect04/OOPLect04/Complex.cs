using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLect04
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Image { get; set; }

        //Note : we have to have both functions
        public static bool operator > (Complex left, Complex right)
        {
            if(left?.Real == right?.Real)
            {
                return left?.Image > right?.Image;
            }else
            {
                return left?.Real > right?.Real;
            }
        }

        public static bool operator < (Complex left, Complex right)
        {
            if (left?.Real < right?.Real)
            {
                return left?.Image < right?.Image;
            }
            else
            {
                return left?.Real < right?.Real;
            }
        }
    }
}
