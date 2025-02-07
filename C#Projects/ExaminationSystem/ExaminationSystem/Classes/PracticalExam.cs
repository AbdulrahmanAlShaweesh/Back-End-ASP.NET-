using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numberOfQuestions, Questions[] questions) : base(timeOfExam, numberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Helper.PrintSnakeSeparator(70);
            Console.WriteLine($"{new string('*', 27)} Practical Exam {new string('*', 27)}");
            Helper.PrintSnakeSeparator(70);
            Console.WriteLine("\n\n"); 

            for (int i = 0; i < Questions!.Length; i++)
            {
                Questions question = Questions[i];

                Console.WriteLine($"{question.Header}  |  {question.Marks} Marks");
                Console.WriteLine(question.Body);

                if (question is TrueAndFalseQuestions)
                {
                    Console.WriteLine("1. True     ||     2. False");
                }
                else if (question is MCQChooseOneAnswerQuestion mcq)
                {
                    foreach (var answers in mcq.AnswerList!)
                    {
                        Console.WriteLine($"{answers.AnswerId}. {answers.AnswerText}");
                    }
                }

                Console.WriteLine("--------------------------------------------------");

                bool isValidAnswer;
                int answer;
                do
                {
                    Console.Write("\nEnter Your Answer: ");
                    isValidAnswer = int.TryParse(Console.ReadLine(), out answer);
                } while (!isValidAnswer);

                StudentsAnswer[i] = answer;
                Console.WriteLine("==================================================");
            }

            Console.Clear();
            ExamResult();
        }
    }
}
