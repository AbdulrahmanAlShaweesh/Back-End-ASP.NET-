using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class Answers
    {
        #region Properities
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answers(int answerId, string? answerText)
        {
            this.AnswerId = answerId;
            this.AnswerText = answerText;
        } 
        #endregion
    }
}
