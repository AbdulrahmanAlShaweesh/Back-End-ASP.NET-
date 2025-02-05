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
        public string? Header { get; set; } 
        public string? Body { get; set; }
        public decimal Marks { get; set; }
        #endregion

        // Will be called each time we create an object from this class
        #region Constructors  
        public Questions(string? header, string? body, decimal marks)
        {
            this.Header = header;
            this.Body = body;
            this.Marks = marks;
        } 
        #endregion

        public virtual void QuestionInformations() { }
    }
}
