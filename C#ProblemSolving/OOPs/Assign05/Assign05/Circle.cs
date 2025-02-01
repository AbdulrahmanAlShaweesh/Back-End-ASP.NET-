using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign05
{
    internal class Circle : ICircle
    {
 
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Areas => Math.PI * Radius * Radius;


        public void DisplayShapeInformation()
        {
            Console.WriteLine($"Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Areas:F2}");
        }

    }
}
