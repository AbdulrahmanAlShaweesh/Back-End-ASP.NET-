namespace C__OOP_L06
{
    internal class Program
    {
        #region Read Points With TryParce
        public static Point3D ReadPointWithTryParse()
        {
            double x, y, z;
            Console.WriteLine("Please Enter coordiantes of the points");

            do
            {
                Console.Write("PLease Enter the first coordiante (x-axis): ");

            } while (!double.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.Write("Please Enter the second coordiante (y-axis): ");

            }
            while (!double.TryParse(Console.ReadLine(), out y));

            do
            {
                Console.Write("Please Enter the third coordiante (z-axis): ");

            }
            while (!double.TryParse(Console.ReadLine(), out z));
            return new Point3D(x, y, z);
        }
        #endregion
        #region Read Points With Convert Method
        public static Point3D ReadPointWithConvert()
        {
            double x = 0, y = 0, z = 0;
            Console.WriteLine("PLease Enter coordiantes of the point");

            try
            {
                Console.Write("PLease Enter the first coordiante (x-axis): ");
                x = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("This value can't be converted to double");
            }

            try
            {
                Console.Write("Enter the second coordiante (y-axis): ");
                y = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("This value can't be converted to double");
            }


            try
            {
                Console.Write("Enter the third coordiante (z-axis): ");
                z = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("This value can't be converted to double");
            }

            return new Point3D(x, y, z);



        } 
        #endregion

        static void Main(string[] args)
        {
            #region 3 - Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Point3D P1 = ReadPointWithTryParse();
            //Console.WriteLine("----------------***********----------------");
            //Point3D P2 = ReadPointWithConvert();

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());
            #endregion

            #region 4 - Try to use  (P1 == P2) 
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(1, 2, 3);
            //Console.WriteLine(P1 == P2);  
            //Console.WriteLine($"P1: {P1.GetHashCode()}");
            //Console.WriteLine($"P2: {P2.GetHashCode()}");
            //int x = 5, y = 5;
            //Console.WriteLine(x == y);  
            #endregion

            #region 5 - Define an array of points and sort this array based on X & Y coordinates.

            //Point3D[] point3Ds = [
            //    new(1,6,3),
            //    new(1,2,3),
            //    new(4,5,6)
            //    ];
            //Array.Sort(point3Ds);  
            //foreach (var point3D in point3Ds)
            //    Console.WriteLine(point3D);
            #endregion

            #region 6 - Implement ICloneable interface to be able to clone the object.

            //Point3D oldPoint = new(1, 2, 3);
            //Point3D newPoint = (Point3D)oldPoint.Clone();
            //Console.WriteLine($"Old point hashcode: {oldPoint.GetHashCode()}");
            //Console.WriteLine($"New point hashcode: {newPoint.GetHashCode()}");

            #endregion




        }
    }

}
