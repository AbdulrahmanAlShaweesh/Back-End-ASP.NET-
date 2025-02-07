using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal abstract class Exam    // based class for all exams type : final , and practical
    {
        #region Properities
        public int TimeOfExam { get; set; }         // time student will take the exam e.g 60 minutes
        public int NumberOfQuestions { get; set; }
        public Questions[]? Questions { get; set; }
        public int[] StudentsAnswer { get; set; }

        #endregion

        #region Constructor
        public Exam(int timeOfExam, int numberOfQuestions , Questions[] questions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            StudentsAnswer = new int[numberOfQuestions];
            Questions = questions;
        }

        #endregion

        public abstract void ShowExam();

        //public abstract void ExamResult();
        public void ExamResult()
        {
            Helper.PrintSnakeSeparator(70);
            Console.WriteLine($"{new string('*', 28)} Exam Results {new string('*', 28)}");
            Helper.PrintSnakeSeparator(70);

            int totalScore = 0;
            int maxScore = 0;

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.Write($"\nQ{i + 1}: {Questions![i].Body} :) ");
                if (Questions[i].RightAnswers == StudentsAnswer[i])
                {
                    Console.WriteLine("Correct");
                    totalScore += (int)Questions[i].Marks;
                }
                else
                {
                    Console.WriteLine("Incorrect ❌");
                }
                maxScore += (int)Questions[i].Marks;
            }

            Console.WriteLine($"\nYour Exam Grade is: {totalScore} From {maxScore}\n");
        }
    }
}
