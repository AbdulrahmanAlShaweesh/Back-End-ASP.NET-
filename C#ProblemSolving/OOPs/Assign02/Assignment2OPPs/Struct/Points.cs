using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OPPs.Struct
{
    internal struct Points
    {
        // Create a struct called "Point" to represent a 2D point with properties "X" and   "Y".
        // Write a C# program that takes two points as input from the user and calculates the distance between them.

        private double x;
        private double y;

        public Points(double X , double Y)
        {
            x = X;
            y = Y;
        }

        public static double CalculateDistanceBetweenTwoPoints(Points p1 , Points p2)
        {
            double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2)); 
            return distance;
        }

    }
}
