using Assignment2OPPs.Struct;

namespace Assignment2OPPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Person Problem 1
            Person[] person = new Person[3];  // array of person and has 3 values...

            person[0] = new Person("Mohammed", 20);
            person[1] = new Person("Sager", 28);
            person[2] = new Person("Mona", 25);

            Console.WriteLine("Person's Detials");

            for (int i = 0; i < person.Length; i++)
            {
                string details = person[i].DisplayDetials();
                Console.WriteLine(details);
            }
            #endregion Proble

            #region Points : Coordinates
            DisplayPoints();
            #endregion

            OldestPerson();
            Rectangle();
        }
        #region Points Function Problem 2
        public static void DisplayPoints()
        {
            Console.WriteLine("Enter the Coordinate for first and second points : ");
            Console.Write("X1 : ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 : ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            // input for the second point
            Console.Write("X2 : ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Y2 : ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Points point1 = new Points(x1, y1);
            Points point2 = new Points(x2, y2);

            Console.WriteLine($"The Distance Between The two points is : {Math.Round(Points.CalculateDistanceBetweenTwoPoints(point1, point2), 2)}");
        }
        #endregion

        #region Oldest Person Function Problem 3
        public static void OldestPerson()
        {
            // Create a struct called "Person" with properties "Name" and "Age".
            // Write a C# program that takes details of 3 persons as input from the user
            // and displays the name and age of the oldest person.

            int age;
            bool isAge;
            string name;

            
            bool IsParse = int.TryParse(Console.ReadLine(), out int NumberOfPerson);
            Person[] P = new Person[NumberOfPerson];

            Console.WriteLine(P.Length);

            for (int i = 0; i < NumberOfPerson; i++)
            {
                 

                name = Console.ReadLine() ?? "Enter a valid Name";
                isAge = int.TryParse(Console.ReadLine(), out age);

                P[i] = new Person(name , age);
            }

            for (int i = 0; i < P.Length;i++)
            {
                Console.WriteLine($"{i+1}:  Name {P[i].PersonName} , and Age {P[i].PersnAge}");
            }

        }
        #endregion

        #region Rectangle : Problem 4
        public static void Rectangle()
        {
            Rectangle R1 = new Rectangle(10.4, 23.3);
            R1.DisplayInfo();

            Rectangle R2 = new Rectangle(3.42, 2.3);
            R2.DisplayInfo();

            Rectangle R3 = new Rectangle(12.43, 5.3);
            R3.DisplayInfo();
        }


        #endregion
    }
}
