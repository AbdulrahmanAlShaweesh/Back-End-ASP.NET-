using System.Diagnostics;
using ExaminationSystem.Classes;
using ExaminationSystem.Enums;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////// App Run ///////////////////////////////////////

            Helper.PrintSnakeSeparator(70);
            Console.WriteLine($"{new string('*', 20)} Welcome To Examination System {new string('*', 19)}");
            Helper.PrintSnakeSeparator(70);
            Console.WriteLine();
            Console.WriteLine();

            bool IsSubjectId;
            int SubjectId;

            string? SubjectName;

            Console.Write("Please Enter Subject  ID : ");
            do
            {
                IsSubjectId = int.TryParse(Console.ReadLine(), out SubjectId);
            } while (!IsSubjectId);

            Console.Write("Please Enter Subject  Name : ");
            do
            {
                SubjectName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(SubjectName));

            
            Subjects sub01 = new Subjects(SubjectId, SubjectName);
            Console.Clear();

            sub01.CreateExam();


            ///////////////////////////////////// To Start The Exam ///////////////////////////////////
            string? StartExam;

            Console.Write("Do You Want to Start The Exam (Y/N) : ");

            do
            {
                StartExam = Console.ReadLine()?.Trim().ToUpper() ?? "Enter (Y/N) :)";

            } while (string.IsNullOrWhiteSpace(SubjectName) || StartExam != "Y" && StartExam != "N");

            if(StartExam == "Y") {
                Console.Clear(); 
                if (sub01.Exam != null)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    sub01.Exam.ShowExam();
                    sw.Stop();

                    Console.WriteLine($"Subject Name : {SubjectName}  |  Subject Code : {SubjectId}");
                    Console.WriteLine($"\nExam Completed in {sw.Elapsed.Minutes} min {sw.Elapsed.Seconds} sec");
                    //Console.WriteLine($"{new string('*', 71)}\n");
                    Helper.PrintSnakeSeparator(70);
                }
                else
                {
                    Console.WriteLine("Error: No exam found! Please create an exam first.");
                }
            }
            else
            {
                Console.WriteLine("Exam Cancelled. Exiting...");
            }
        }
        
    }
}
