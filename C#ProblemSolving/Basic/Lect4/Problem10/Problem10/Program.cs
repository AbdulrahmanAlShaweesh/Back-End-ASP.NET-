namespace Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            
            float X1 , X2 , X3 , Y1 , Y2 , Y3 ;
            bool flag;

            do
            {

                Console.Write("Enter a value for X1 : ");
                flag = float.TryParse(Console.ReadLine(), out X1);
                Console.Write("Enter a value for X2 : ");
                flag = float.TryParse(Console.ReadLine(), out X2);
                Console.Write("Enter a value for X3 : ");
                flag = float.TryParse(Console.ReadLine(), out X3);

                Console.Write("Enter a value for Y1 : ");
                flag = float.TryParse(Console.ReadLine(), out Y1);
                Console.Write("Enter a value for Y2 : ");
                flag = float.TryParse(Console.ReadLine(), out Y2);
                Console.Write("Enter a value for Y3 : ");
                flag = float.TryParse(Console.ReadLine(), out Y3);
            } while (!flag);

            // Calcuated Slop 
            float Slopy1 = (Y2 - Y1) / (X2 - X1);
            float Slopy2 = (Y3 - Y2) / (X3 - X1);

            if(Slopy1 == Slopy2)
            {
                Console.WriteLine("Both Points are on a stright point");   
            }else
            {
                Console.WriteLine("Both Points are on diff stright point");
            }
            #endregion
        }
    }
}
