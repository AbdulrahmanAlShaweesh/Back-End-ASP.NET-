using Assignement1OOPs.Enums;

namespace Assignement1OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDay();
            Console.WriteLine($"{new string('*', 50)}");
            Season();
            Console.WriteLine($"{new string('*', 50)}");
            Permission();
            Console.WriteLine($"{new string('*', 50)}");
            Color();
        }

        #region WeekDays : Problem 01    
        public static void WeekDay()
        {
            /*
        * Create an Enum called "WeekDays" with the days of the week 
        * (Monday to Sunday) as its members. Then, write a C# program 
        * that prints out all the days of the week using this Enum.
       */


            WeekDays[] weekDays = { WeekDays.Monday, WeekDays.Tuesday,
                                WeekDays.Wednesday, WeekDays.Thursday,
                                WeekDays.Friday, WeekDays.Saturday,
                                WeekDays.Sunday
                               };
            int counter = 1;

            foreach(WeekDays day in weekDays)
            {
                Console.WriteLine($"{counter}. {day.ToString()}");
                counter++;
            }
        }
        #endregion

        #region Seas : Problem 02      
        public static void Season()
        {
            /*
             * Create an Enum called "Seas on" with the four seasons 
             * (Spring, Summer, Autumn, Winter) as its members. 
             * Write a C# program that takes a season name as input 
             * from the user and displays the corresponding month range 
             * for that season. Note range for seasons ( spring march to may , summer june to august , 
             * autumn September to November , winter December to February)
             */

            Seasons season;
            bool IsSeasonParsed;

            do {
                Console.Write("Please Enter Season Name : ");
                IsSeasonParsed = Enum.TryParse(Console.ReadLine(), out season);
            } while (!IsSeasonParsed);


            if(season == Seasons.Spring)
            {
                Console.WriteLine("March-May");
            }else if (season == Seasons.Summer) {
                Console.WriteLine("June-August");
            }else if(season == Seasons.Autumn)
            {
                Console.WriteLine("September-November");
            }else if(season == Seasons.Winter)
            {
                Console.WriteLine("December-February");
            }
        }
        #endregion

        #region Permissions : Problems 03    
        public static void Permission()
        {
            /* 
             * Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
             * Create Variable from previous Enum to Add and Remove Permission from variable, 
             * check if specific Permission existed inside variable
             */
            User user = new User();
            user.Id = 1;                // allocate 4 bytes at stack
            user.Permissions = (Permissions)3;  // Read, Write
                                                // 00000011 => 3 decimal = Read, Write
                                                // using XOR to add a permission
            Console.WriteLine(user.Permissions);
            user.Permissions ^= Permissions.Delete;  // if Delete exist will remove it from the permision list
            Console.WriteLine("After adding Delete Permission");
            Console.WriteLine(user.Permissions);
            user.Permissions ^= Permissions.Read;  // will remove read due to its alreadyexist

            // CHECK IF PERMISSION IN THE LIST, IF YES IGNOURE ELSE ADD IT TO PERMISSIONS LIST
            if ((user.Permissions & Permissions.Read) != Permissions.Read) { // IF READ NOT IN THE PERMISSIONS LIST

                bool IsPermission;
                Permissions Permission;

                do
                {
                    Console.WriteLine("Please Enter Permission : ");
                    IsPermission = Enum.TryParse(Console.ReadLine()!.Trim(), out  Permission);
                } while (!IsPermission);

                user.Permissions ^= Permissions.Read;
            }else
            {
                Console.WriteLine($"Permission {Permission} already exist");
            }
            Console.WriteLine(user.Permissions);
            // remove permision 
            user.Permissions ^= Permissions.Delete;
            Console.WriteLine("After removing Delete Pemission");
            Console.WriteLine(user.Permissions);
            user.Permissions |= Permissions.Read; // adding Read permission using OR : if exist will leave it as it is
            Console.WriteLine("After adding Read Permission using OR operator");
            Console.WriteLine(user.Permissions);
        }
        #endregion

        #region Colors : Problem 04  
        public static void Color()
        {
            Colors colors;
            bool IsColorParsed;

            do
            {
                Console.Write("Please Enter a color Name : ");
                IsColorParsed = Enum.TryParse(Console.ReadLine()!.Trim(),out colors);
            } while (!IsColorParsed);

            if (colors == Colors.Green || colors == Colors.Red || colors == Colors.Blue)
            {
                Console.WriteLine($"The color {colors} is a primary color");
            }else
            {
                Console.WriteLine($"The color {colors} is not a primary color");
            }
        }
        #endregion

    }
}
