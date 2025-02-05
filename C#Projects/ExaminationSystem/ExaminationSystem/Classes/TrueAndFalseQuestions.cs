using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class TrueAndFalseQuestions : Questions  // this is the first type of question and will inerit question class
    {
        #region Properity
        bool IsAnswerCorrect { get; set; }
        #endregion

        #region Constructor
        public TrueAndFalseQuestions(string? header, string? body, decimal marks, bool IsAnswerCorrect) 
            : base(header, body, marks)
        {
            this.IsAnswerCorrect = IsAnswerCorrect;
        } 
        #endregion
    }
}
