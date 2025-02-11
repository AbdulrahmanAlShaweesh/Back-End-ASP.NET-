using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_L06
{
    internal class Point3D
    {

        #region This is th 3D Point Properaties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        #endregion


        #region This is the Main Constructor
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion


        #region Rest Constractours
        public Point3D(double x, double y) : this(x, y, 0)
        {
            X = x;
            Y = y;
        }

        public Point3D(double x) : this(x, 0, 0) { }

        public Point3D(Point3D point3D)
        {
            X = point3D.X;
            Y = point3D.Y;
            Z = point3D.Z;
        }

        #endregion


        #region Business Logic
        public override string ToString() => $"Point Coordinates: ({X}, {Y}, {Z})";
        public static bool operator ==(Point3D right, Point3D left)
        {
            return right.X == left.X && right.Y == left.Y && right.Z == left.Z;
        }

        public static bool operator !=(Point3D right, Point3D left)
        {
            return !(right == left);
        }
        public int CompareTo(object? obj)
        {
            Point3D point3D = (Point3D)obj!;

            if (X == point3D.X)
                return Y.CompareTo(point3D.Y);

            return X.CompareTo(point3D.X);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        } 
        #endregion
    }
}
