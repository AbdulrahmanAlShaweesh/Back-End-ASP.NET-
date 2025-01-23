using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OPPs.Struct
{
    internal struct Rectangle
    {
        private double width; 
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (width < 0)
                {
                    Console.WriteLine("Width can not be a negative");
                }else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if(height < 0)
                {
                    Console.WriteLine("Height can not be a negative");
                }else
                {
                    height = value;
                }
            }
        }

        // calclate the area
        public double Area
        {
            // read only parameter
            get { return width * height; }
        }

        // override the tostring method
        public void  DisplayInfo()
        {
            Console.WriteLine($"The dimentional of Rectangle with a width of {width} , and height {height} is {Math.Round(Area , 2)}");
        }
    }
}
