using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Enums;

namespace ExaminationSystem.Classes
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions, Questions[] questions) : 
            base(timeOfExam, numberOfQuestions, questions)
        {
        }

        

        public override void ShowExam()
        {
            Helper.PrintSnakeSeparator(70);
            Console.WriteLine($"{new string('*', 20)} Your Exam Begin Started {new string('*', 20)}");
            Helper.PrintSnakeSeparator(70);
            Console.WriteLine("\n\n");

            if (Questions is not null) {

                for(int i = 0; i < Questions.Length; i++)
                {
                    Questions question = Questions[i];
                    string markText = question.Marks > 1 ? "Marks" : "Mark";

                    Console.WriteLine($"{question.Header}  |  {question.Marks} {markText}");
                    Console.WriteLine(question.Body);

                    if(question is TrueAndFalseQuestions)
                    {
                        Console.WriteLine("1. True     ||     2. False");
                    }
                    else if (question is MCQChooseOneAnswerQuestion MCQQ)
                    {
                        foreach (var answers in MCQQ.AnswerList!)
                        {
                            Console.Write($"{answers.AnswerId}. {answers.AnswerText} {new string(' ', 10)}");
                        }
                        Console.WriteLine();
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
}
