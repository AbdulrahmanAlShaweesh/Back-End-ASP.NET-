using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class MCQChooseOneAnswerQuestion : Questions
    {
        public MCQChooseOneAnswerQuestion(string? header, string? body, decimal marks) : 
            base(header, body, marks)
        {

        }

       
    }
}
