    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ExaminationSystem.Classes
    {
        internal class MCQChooseOneAnswerQuestion : Questions
        {
            #region Constructor
            public MCQChooseOneAnswerQuestion(string? header, string? body, int marks, int NumberOfAnswers) :
               base(header, body, marks, NumberOfAnswers)
            {
                AnswerList = new Answers[NumberOfAnswers];
            } 

            #endregion

            #region Methods
            // Adding an answer
            public void AddAnswer(int id, int answerId, string answerText)
            {
                if (id >= 0 && id < AnswerList!.Length)
                {
                    AnswerList![id] = new Answers(answerId, answerText);
                }else
                {
                    Console.WriteLine($"Error: Index {id} is out of bounds.");
                }
            }
     
            // show available chooise
            public override void QuestionInformations()
            {
                if (AnswerList is not null && AnswerList.Length > 0)
                {
                    Console.WriteLine("\nChoose one of the following answers:");
                    for (int i = 0; i < AnswerList!.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {AnswerList[i].AnswerText}");
                        //Console.WriteLine($"{AnswerList[i].AnswerId}   ||   {AnswerList[i].AnswerText}");
                    }
                }
            }

            // check if the Student answer is right or not right answer
            public override bool CkeckUserAnswer(int StudentAnswer)
            {
                bool isCorrect = (StudentAnswer - 1) == RightAnswers; // Convert user input from 1-based to 0-based
                Console.WriteLine($"User's answer: {StudentAnswer}, Correct answer index: {RightAnswers + 1}, Is Correct: {isCorrect}");
                return isCorrect;
                //bool isCorrect = StudentAnswer == RightAnswers;
                //Console.WriteLine($"User's answer: {StudentAnswer}, Correct answer: {RightAnswers}, Is Correct: {isCorrect}"); // Debugging line
                //return isCorrect;
            }

        public void SetCorrectAnswer(int correctIndex)
        {
            if (correctIndex >= 1 && correctIndex <= AnswerList!.Length)
            {
                RightAnswers = correctIndex ; // Convert from 1-based to 0-based index
                //Console.WriteLine($"Correct answer set to: {RightAnswers }"); // Debugging line
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter a valid option.");
            }
        }

        #endregion
    }
    }
