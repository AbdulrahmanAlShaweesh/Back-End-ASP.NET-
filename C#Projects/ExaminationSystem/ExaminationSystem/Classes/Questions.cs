using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal abstract class Questions
    {
        // Properities for the exam [Question , Answer , and Marks]
        #region Properities
        public string? Header { get; set; }        // Title of the Questions
        public string? Body { get; set; }          // Description of the Questions
        public int Marks { get; set; }         // Question's Marks
        public Answers[]? AnswerList { get; set; } // all answers (Options for each answer)
        public int RightAnswers { get; set; }      // the right answer of the question
        #endregion

        // Will be called each time we create an object from this class
        #region Constructors  
        public Questions(string? header, string? body, int marks, int NumberOfAnswers)
        {
            this.Header = header;
            this.Body = body;
            this.Marks = marks;
            this.AnswerList = new Answers[NumberOfAnswers];
        }
        #endregion

        public abstract void QuestionInformations();    // this function will be override
                                                        // for each question typE
        public abstract bool CkeckUserAnswer(int StudentAnswer); // check user answer
    }
}
