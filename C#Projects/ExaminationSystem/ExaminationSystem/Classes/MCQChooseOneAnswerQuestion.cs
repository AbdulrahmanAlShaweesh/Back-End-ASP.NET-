using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class MCQChooseOneAnswerQuestion : Questions
    {
        public MCQChooseOneAnswerQuestion(string? header, string? body, decimal marks, int NumberOfAnswers) :
            base(header, body, marks, NumberOfAnswers)
        {
        }

        // Adding an answer
        public void AddAnswer(int answerId, string answerText)
        {
            AnswerList![answerId - 1] = new Answers(answerId, answerText);
        }

        // show available chooise
        public override void QuestionInformations()
        {
            if (AnswerList is not null && AnswerList.Length > 0)
            {
                for (int i = 0; i < AnswerList!.Length; i++)
                {
                    Console.WriteLine($"{AnswerList[i].AnswerId}   ||   {AnswerList[i].AnswerText}");
                }
            }
        }

        // check the if the Student answer is right or not right answer
        public override bool CkeckUserAnswer(int StudentAnswer)
        {
            return StudentAnswer == RightAnswers;
        }
    }
}
