using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Enums;

namespace ExaminationSystem.Classes
{
    internal class TrueAndFalseQuestions : Questions  // this is the first type of question and will inerit question class
    {
        #region Properity
        //private bool IsAnswerCorrect { get; set; }  // Encapsulated for better control
        #endregion

        #region Constructor
        public TrueAndFalseQuestions(string? header, string? body, int marks, bool IsAnswerCorrect) 
            : base(header, body, marks, 2)
        {
            RightAnswers = IsAnswerCorrect ? 1 : 2;
        }
        #endregion

        #region Methods  
        public override void QuestionInformations()
        {
            string pointsText = Marks > 1 ? "\\Points\\" : "Point";
            Console.WriteLine($"{Header} : {Body} || Carry {Marks} {pointsText}");
            int counter = 1;

            foreach (TrueOrFalseAnswer value in Enum.GetValues(typeof(TrueOrFalseAnswer)))
            {
                Console.WriteLine($"{counter}. {value}");
                counter++;
            }
        }

        public override bool CkeckUserAnswer(int StudentAnswer)
        {
            return StudentAnswer == RightAnswers;
        } 
        #endregion
    }
}
