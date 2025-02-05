using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class Questions
    {
        // Properities for the exam [Question , Answer , and Marks]
        #region Properities
        public string? Header { get; set; }        // Title of the Questions
        public string? Body { get; set; }          // Description of the Questions
        public decimal Marks { get; set; }         // Question's Marks
        public Answers[]? AnswerList { get; set; } // all answers (Options for each answer)
        public int RightAnswers { get; set; }      // the right answer of the question
        #endregion

        // Will be called each time we create an object from this class
        #region Constructors  
        public Questions(string? header, string? body, decimal marks)
        {
            this.Header = header;
            this.Body = body;
            this.Marks = marks;
            AnswerList = new Answers[3];
        }
        #endregion

        public  virtual void QuestionInformations() { }      // this function will be override
                                                             // for each question type

    }
}
