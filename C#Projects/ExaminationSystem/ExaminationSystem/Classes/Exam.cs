using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal abstract class Exam    // based class for all exams type : final , and practical
    {
        #region Properities
        public int TimeOfExam { get; set; }  // time student will take the exam e.g 60 minutes
        public int NumberOfQuestions { get; set; }
        public Questions[] Questions { get; set; }

        #endregion

        #region Constructor
        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }

        #endregion

        #region Methods     
        public abstract void ShowExam();  // we need to impelement this method in each class it inherit
                                          // from exam class. 
        #endregion
    }
}
