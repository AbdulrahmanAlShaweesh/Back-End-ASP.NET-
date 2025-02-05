using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal abstract class Exam    // based class for all exams type : final , and practical
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public abstract void ShowExam();  // we need to impelement this method in each class it inherit
                                          // from exam class.
    }
}
