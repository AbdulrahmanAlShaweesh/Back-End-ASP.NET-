using OOPsAssignment03.Classes;
using OOPsAssignment03.Enums.Quation1;

namespace OOPsAssignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Emplyees E1 = new Emplyees(1 , "Mohammed Sager" , "M" , Enums.Quation1.SecurityLevel.Guest , 24000 , new HireDate(1 , 12 , 2017));
            Console.WriteLine(E1);

            Emplyees E2 = new Emplyees(2, "Nada Tarek", "F", Enums.Quation1.SecurityLevel.Developer, 39500, new HireDate(12, 2, 2015));
            Console.WriteLine(E2);

            Emplyees E3 = new Emplyees(3, "Sarah Malek", "F", Enums.Quation1.SecurityLevel.DBA, 33203, new HireDate(8, 5, 2022));
            Console.WriteLine(E3);
            #endregion

            #region Question 2
            HireDate hireDate = new HireDate(1, 3, 2022);
            Console.WriteLine(hireDate);
            #endregion

            #region Question3
            Emplyees[] Emps = new Emplyees[3];
            Emps[0] = new Emplyees(
                        id: 1, name: "Sager", gender: "M", securityLevel: SecurityLevel.Guest, salary: 83400m,
                        hireDate: new HireDate(1, 2, 2022)
                    );

            Emps[1] = new Emplyees(
                        id: 1, name: "Sara", gender: "F", securityLevel: SecurityLevel.DBA, salary: 123432m,
                        hireDate: new HireDate(11, 23, 2018)
                    );

            Emps[2] = new Emplyees(
                        id: 1, name: "Shahd", gender: "F", securityLevel: SecurityLevel.Developer, salary: 45434m,
                        hireDate: new HireDate(21, 10, 2015)
                    );

            foreach (var item in Emps)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question 4
            BoxingAndUnboxing();
            #endregion

            #region Question 5
            LibrarySystem();
            #endregion
        }

        #region Boxing and Unboxing Problem 4
        public static void BoxingAndUnboxing()
        {
            Emplyees[] Emps = new Emplyees[3];

            Emps[0] = new Emplyees(
                id: 1,
                name: "Alia",
                gender: "F",
                securityLevel: SecurityLevel.DBA,
                salary: 95000m,
                hireDate: new HireDate(15, 3, 2018)
            );

            Emps[1] = new Emplyees(
                id: 2,
                name: "Khalid",
                gender: "M",
                securityLevel: SecurityLevel.Guest,
                salary: 40000m,
                hireDate: new HireDate(10, 7, 2022)
            );

            Emps[2] = new Emplyees(
                id: 3,
                name: "Abdulrahman",
                gender: "M",
                securityLevel: SecurityLevel.SecurityOfficer,
                salary: 120000m,
                hireDate: new HireDate(5, 1, 2020)
            );


            int boxing = 0;
            Emps = Emps.OrderBy(emp =>
            {
                boxing++;
                return (emp.HireDate.year, emp.HireDate.month, emp.HireDate.day);
            }).ToArray();

            foreach (var item in Emps)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine($"Number of Boxing and Unboxing is {boxing}");
        }
        #endregion

        #region Question 5 Library Management System
        public static void LibrarySystem()
        {
            Book[] library = new Book[3];

            // Add EBook and PrintedBook instances to the library
            library[0] = new EBook("EBook Title 1", "Author A", "123-4567890123" , 2.3);
            library[1] = new PrintedBook("Printed Book Title 2", "Author B", "234-5678901234", 320);
            library[2] = new EBook("EBook Title 3", "Author C", "345-6789012345", 9.8);

            Console.WriteLine($"{new string('*', 20)} Book Are {new string('*', 20)}");
            foreach (var item in library)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine($"{new string('*', 51)}");
        }
        #endregion
    }
}
