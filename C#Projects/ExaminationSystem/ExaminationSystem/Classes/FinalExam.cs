using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam Started");
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                var question = Questions[i];
                Console.WriteLine($"{question.Header} ({question.Marks} Marks)");
                Console.WriteLine(question.Body);
                question.QuestionInformations();

                int userAnswer = int.Parse(Console.ReadLine() ?? "Please enter Your answer in number:)");
                bool isCorrect = question.CkeckUserAnswer(userAnswer);
                Console.WriteLine(isCorrect ? "Your Answer is Correct!" : " Your Answer is Incorrect.");
            }
        }
    }
}
