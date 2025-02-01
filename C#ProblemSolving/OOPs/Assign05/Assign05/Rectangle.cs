using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign05
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Areas => Length * Width;


        public void DisplayShapeInformation()
        {
            Console.WriteLine($"Shape: Rectangle");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {Areas:F2}");
        }
 
    }
}
