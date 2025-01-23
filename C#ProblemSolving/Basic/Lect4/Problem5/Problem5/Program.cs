namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to enter marks of five subjects and calculate total, average and percentage.

            Console.Write("Enter Mark For first Subject ? ");
            float.TryParse(Console.ReadLine(), out float Subject1);

            Console.Write("Enter Mark For Second Subject ? ");
            float.TryParse(Console.ReadLine(), out float Subject2);

            Console.Write("Enter Mark For Third Subject ? ");
            float.TryParse(Console.ReadLine(), out float Subject3);

            Console.Write("Enter Mark For Fourth Subject ? ");
            float.TryParse(Console.ReadLine(), out float Subject4);

            Console.Write("Enter Mark For Fifth Subject ? ");
            float.TryParse(Console.ReadLine(), out float Subject5);

            float total = Subject1 + Subject2 + Subject3 + Subject4 + Subject5;
            Console.WriteLine($"The Total Scoure {total}");
            Console.WriteLine($"The Average {total / 5}");
            Console.WriteLine($"Percentage {(total / 500):P}");

            // --------------------------------------- OR We can us loop --------------------------------------------
            float totalMarks = 0;

            for (int i = 0; i < 5; i++) {
                Console.Write($"Enter Marks For Subject {i + 1} : ");
                float.TryParse(Console.ReadLine(), out float marks);

                totalMarks += marks;
            }

            
            float Average = totalMarks / 5;
            float Percentage = totalMarks / 500; 

            Console.WriteLine($"The Total Scoure {totalMarks}");
            Console.WriteLine($"The Average {Average}");        
            Console.WriteLine($"Percentage {(Percentage * 100)}%");
        }
    }
}
