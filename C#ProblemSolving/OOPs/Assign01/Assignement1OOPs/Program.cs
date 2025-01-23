using Assignement1OOPs.Enums;

namespace Assignement1OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            weekOfDays();
            Console.WriteLine($"{new string('*', 50)}");
            seasons();
            Console.WriteLine($"{new string('*', 50)}");
            PrimaryColor();
            Permiss();
        }

        #region Problem 1
        static void weekOfDays()
        {
            // Display Week Of the days..
            Console.WriteLine(DayOfWeek.Monday);
            Console.WriteLine(DayOfWeek.Tuesday);
            Console.WriteLine(DayOfWeek.Wednesday);
            Console.WriteLine(DayOfWeek.Thursday);
            Console.WriteLine(DayOfWeek.Friday);
            Console.WriteLine(DayOfWeek.Saturday);
            Console.WriteLine(DayOfWeek.Sunday);

            // using foreach
            Console.WriteLine("\nWill use Foreach to Display the data\n");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day.ToString());
            }
        }
        #endregion

        #region Problem 2
        static void seasons()
        {
            
            Console.WriteLine("Enter seasons name : ");
            string Input = Console.ReadLine()??"enter season name";

            if (Enum.TryParse(Input, true, out Seas season))
            {
                switch (season)
                {
                    case Seas.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Seas.Summer:
                        Console.WriteLine("Summer : June to Augost");
                        break;
                    case Seas.Autom:
                        Console.WriteLine("Autom : Septamber to November");
                        break;
                    case Seas.Winter:
                        Console.WriteLine("Winter : Decimber to February");
                        break;
                }
            }
        }
        #endregion

        #region Problem 3
        static void Permiss() {
            User user = new User();
            user.Permissions = (Permissions)3;

            user.Permissions = user.Permissions ^ Permissions.Delete; // adding write permission to use using XOR
            Console.WriteLine(user.Permissions);

            // Remove / Deny Write From User using XOR
            user.Permissions = user.Permissions ^ Permissions.Write;
            Console.WriteLine(user.Permissions);

            if((user.Permissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("User has Read Permission");
            }
            else
            {
                Console.WriteLine("User does not have Read Permission");
            }
        }
        #endregion

        #region
        static void PrimaryColor()
        {
            Console.WriteLine("Enter a Color: ");
            string color = Console.ReadLine() ?? "Enter a valid Color name"; 

            if(Enum.TryParse(color , out Colors colors))
            {
                switch (colors)
                {
                    case Colors.Red: 
                        Console.WriteLine("the color red is primary color");
                        break;
                    case Colors.Green:
                        Console.WriteLine("The color green is not a primary color");
                        break; 
                    case Colors.Blue:
                        Console.WriteLine("The color blue is a primary color");
                        break;
                    default: 
                        Console.WriteLine($"The color {color} is not primary color");
                        break;
                }
            }
        }
        #endregion
    }
}
