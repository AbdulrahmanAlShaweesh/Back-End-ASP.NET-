using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    internal class Subjects 
    {

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? Exam { get; set; }

        public Subjects(int subjectId, string? subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        //public void CreateExam()
        //{
        //    Console.WriteLine($"{new string('*', 95)}");
        //    Console.WriteLine("Note: Final Exam Includes Both (MCQ + True/False), but Practical Exam Includes only MCQ) : ");
        //    Console.Write("Please Enter the Type of Exam you want to create (1 for Practical and 2 for Final Exam)   : ");

        //    /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //    bool IsTypesOfExams;
        //    int ExamTypes;

        //    do
        //    {
        //        IsTypesOfExams = int.TryParse(Console.ReadLine(), out ExamTypes);
        //    } while (!IsTypesOfExams || (ExamTypes != 1 && ExamTypes != 2));

        //    /////////////////////////////////////////// Time Will Taken To Solve The Exam ////////////////////////////////
        //    Console.Write("Please Enter the Time of the Exam in minutes : ");
        //    bool IsExamTime;
        //    int ExamTimeTaken;

        //    do
        //    {
        //        IsExamTime = int.TryParse(Console.ReadLine(), out ExamTimeTaken);
        //    } while (!IsExamTime);

        //    ////////////////////////////////////////// Number of The Questions //////////////////////////////////////////
        //    Console.Write("Please Enter the Number of Questions To Create: ");
        //    bool IsNumberOfQuestions;
        //    int NumberOfQuestions;
        //    do
        //    {
        //        IsNumberOfQuestions = int.TryParse(Console.ReadLine(), out NumberOfQuestions);
        //    } while (!IsNumberOfQuestions || NumberOfQuestions <= 0);

        //    Console.WriteLine($"{new string('*', 95)}");
        //    Console.Clear();

        //    Questions[] questions = new Questions[NumberOfQuestions];

        //    ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //    for (int i = 0; i < NumberOfQuestions; i++)
        //    {
        //        bool IsQType;
        //        int Qtype;

        //        Console.Write("Please Choose The type of question (1 for True/False Question || 2 For MCQ Question  : ");

        //        do
        //        {
        //            IsQType = int.TryParse(Console.ReadLine(), out Qtype);
        //        } while (!IsQType || (Qtype != 1 && Qtype != 2));


        //        Console.Clear();

        //        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //        if (Qtype == 1)  // True/False Question
        //        {
        //            Console.WriteLine(" True  |  False Questions ");
        //            Console.WriteLine("-------------------------");

        //            /////////////////////////////////////////////////////////////////////////////////////////////////////
        //            string? body;
        //            Console.WriteLine($"Plase Enter Body Of The Question {i + 1}: ");
        //            do
        //            {
        //                body = Console.ReadLine();
        //            } while (string.IsNullOrWhiteSpace(body));


        //            /////////////////////////////////////////////////////////////////////////////////////////////////////
        //            bool IsMark;
        //            int Mark; 

        //            Console.Write($"Please Enter the Marks for the Question {i + 1}: ");
        //            do
        //            {
        //                IsMark = int.TryParse(Console.ReadLine(), out Mark); 
        //            } while (!IsMark);

        //            ////////////////////////////////////////////////////////////////////////////////////////////////////

        //            bool CorrectAnswer;
        //            Console.Write($"Please Enter The Right Answer for Question {i + 1} (1 for True, 2 for False) : ");
        //            int rightAnswer;
        //            do
        //            {
        //                bool isParsed = int.TryParse(Console.ReadLine(), out rightAnswer);
        //                CorrectAnswer = (rightAnswer == 1);
        //            } while (rightAnswer != 1 && rightAnswer != 2);


        //            ///////////////////////////////////////////////////////////////////////////////////////////////////
        //            questions[i] = new TrueAndFalseQuestions("True  |  False Questions", body, Mark, CorrectAnswer);
        //            Console.Clear();
        //        }


        //        /////////////////////////////////////////////////////////////////////////////////////////
        //        else if (Qtype == 2)  // MCQ Question
        //        {
        //            Console.WriteLine(" Choose Only One Answer or Each Question ");
        //            Console.WriteLine("-----------------------------------------");


        //            /////////////////////////////////////////////////////////////////////////////////////
        //            string? body;
        //            Console.WriteLine($"Please Enter Body Of Question {i + 1} : ");
        //            do
        //            {
        //                body = Console.ReadLine();
        //            } while (string.IsNullOrWhiteSpace(body));


        //            /////////////////////////////////////////////////////////////////////////////////////
        //            bool IsMarkedParsed;
        //            int Mark;

        //            Console.Write($"Please Enter the Marks for Question {i + 1} : ");
        //            do
        //            {
        //                IsMarkedParsed = int.TryParse(Console.ReadLine(), out Mark); 
        //            } while (!IsMarkedParsed || Mark < 0);


        //            //////////////////////////////////////////////////////////////////////////////////
        //            MCQChooseOneAnswerQuestion MCQQuestions = new MCQChooseOneAnswerQuestion("MCQ Question", body, Mark, 3);


        //            /////////////////////////////////////////////////////////////////////////////////
        //            Console.WriteLine("The Choices of the Question are : ");
        //            for (int j = 0; j < 3; j++)
        //            {
        //                Console.Write($"Please Enter Choice Number {j + 1} : ");
        //                string? AnswerText;
        //                do
        //                {
        //                    AnswerText = Console.ReadLine();
        //                } while (string.IsNullOrWhiteSpace(AnswerText));

        //                MCQQuestions.AddAnswer(j, j + 1, AnswerText);
        //            }

        //            //////////////////////////////////////////////////////////////////////////////////
        //            Console.WriteLine();
        //            Console.WriteLine("Please Specify The Correct Choice Enter the Choice Number  : ");
        //            int RightAnswer;
        //            bool isCorrect;
        //            do
        //            {
        //                isCorrect = int.TryParse(Console.ReadLine(), out RightAnswer);
        //            } while (!isCorrect || RightAnswer < 1 || RightAnswer > 3);

        //            questions[i] = MCQQuestions;

        //        }
        //    }

        //    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //    if (ExamTypes == 1)     
        //    {
        //        Exam = new PracticalExam(ExamTimeTaken, NumberOfQuestions, questions);
        //    }
        //    else if (ExamTypes == 2)
        //    {
        //        Exam = new FinalExam(ExamTimeTaken, NumberOfQuestions, questions);
        //    }

        //    Console.WriteLine("Exam Created Successfully!");
        //    Console.Clear();
        //}

        public void CreateExam()
        {
           
            Console.WriteLine("Note: Final Exam Includes Both (MCQ + True/False), but Practical Exam Includes only MCQ) : ");
            Console.Write("Please Enter the Type of Exam you want to create (1 for Practical and 2 for Final Exam)   : ");

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            bool IsTypesOfExams;
            int ExamTypes;

            do
            {
                IsTypesOfExams = int.TryParse(Console.ReadLine(), out ExamTypes);
            } while (!IsTypesOfExams || (ExamTypes != 1 && ExamTypes != 2));

            /////////////////////////////////////////// Time Will Taken To Solve The Exam ////////////////////////////////
            Console.Write("Please Enter the Time of the Exam in minutes : ");
            bool IsExamTime;
            int ExamTimeTaken;

            do
            {
                IsExamTime = int.TryParse(Console.ReadLine(), out ExamTimeTaken);
            } while (!IsExamTime);

            ////////////////////////////////////////// Number of The Questions //////////////////////////////////////////
            Console.Write("Please Enter the Number of Questions To Create: ");
            bool IsNumberOfQuestions;
            int NumberOfQuestions;
            do
            {
                IsNumberOfQuestions = int.TryParse(Console.ReadLine(), out NumberOfQuestions);
            } while (!IsNumberOfQuestions || NumberOfQuestions <= 0);

            Console.WriteLine($"{new string('*', 95)}");
            Console.Clear();

            Questions[] questions = new Questions[NumberOfQuestions];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                bool IsQType;
                int Qtype;

                // Enforce MCQ only for Practical Exam
                if (ExamTypes == 1)
                {
                    Console.WriteLine("Practical Exam only allows MCQ questions.");
                    Qtype = 2; // Force MCQ selection
                }
                else
                {
                    Console.Write("Please Choose The type of question (1 for True/False Question || 2 For MCQ Question) : ");
                    do
                    {
                        IsQType = int.TryParse(Console.ReadLine(), out Qtype);
                    } while (!IsQType || (Qtype != 1 && Qtype != 2));
                }

                Console.Clear();

                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (Qtype == 1)  // True/False Question
                {
                    Console.WriteLine(" True  |  False Questions ");
                    Console.WriteLine("-------------------------");

                    /////////////////////////////////////////////////////////////////////////////////////////////////////
                    string? body;
                    Console.WriteLine($"Please Enter Body Of The Question {i + 1}: ");
                    do
                    {
                        body = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(body));

                    /////////////////////////////////////////////////////////////////////////////////////////////////////
                    bool IsMark;
                    int Mark;

                    Console.Write($"Please Enter the Marks for the Question {i + 1}: ");
                    do
                    {
                        IsMark = int.TryParse(Console.ReadLine(), out Mark);
                    } while (!IsMark);

                    ////////////////////////////////////////////////////////////////////////////////////////////////////
                    bool CorrectAnswer;
                    Console.Write($"Please Enter The Right Answer for Question {i + 1} (1 for True, 2 for False) : ");
                    int rightAnswer;
                    do
                    {
                        bool isParsed = int.TryParse(Console.ReadLine(), out rightAnswer);
                        CorrectAnswer = (rightAnswer == 1);
                    } while (rightAnswer != 1 && rightAnswer != 2);

                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    questions[i] = new TrueAndFalseQuestions("True  |  False Questions", body, Mark, CorrectAnswer);
                    Console.Clear();
                }

                /////////////////////////////////////////////////////////////////////////////////////////
                else if (Qtype == 2)  // MCQ Question
                {
                    Console.WriteLine(" Choose Only One Answer for Each Question ");
                    Console.WriteLine("-----------------------------------------\n");

                    /////////////////////////////////////////////////////////////////////////////////////
                    string? body;
                    Console.WriteLine($"Please Enter Body Of Question {i + 1} : ");
                    do
                    {
                        body = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(body));

                    /////////////////////////////////////////////////////////////////////////////////////
                    bool IsMarkedParsed;
                    int Mark;

                    Console.Write($"Please Enter the Marks for Question {i + 1} : ");
                    do
                    {
                        IsMarkedParsed = int.TryParse(Console.ReadLine(), out Mark);
                    } while (!IsMarkedParsed || Mark < 0);

                    //////////////////////////////////////////////////////////////////////////////////
                    MCQChooseOneAnswerQuestion MCQQuestions = new MCQChooseOneAnswerQuestion("MCQ Question", body, Mark, 3);

                    /////////////////////////////////////////////////////////////////////////////////
                    Console.WriteLine("The Choices of the Question are : ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Please Enter Choice Number {j + 1} : ");
                        string? AnswerText;
                        do
                        {
                            AnswerText = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(AnswerText));

                        MCQQuestions.AddAnswer(j, j + 1, AnswerText);
                    }

                    //////////////////////////////////////////////////////////////////////////////////
                    Console.WriteLine();
                    Console.WriteLine("Please Specify The Correct Choice Enter the Choice Number  : ");
                    int RightAnswer;
                    bool isCorrect;
                    do
                    {
                        isCorrect = int.TryParse(Console.ReadLine(), out RightAnswer);
                    } while (!isCorrect || RightAnswer < 1 || RightAnswer > 3);

                    questions[i] = MCQQuestions;
                    MCQQuestions.SetCorrectAnswer(RightAnswer);  // Call to set correct answer

                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ExamTypes == 1)
            {
                Exam = new PracticalExam(ExamTimeTaken, NumberOfQuestions, questions);
            }
            else if (ExamTypes == 2)
            {
                Exam = new FinalExam(ExamTimeTaken, NumberOfQuestions, questions);
            }

            Console.WriteLine("Exam Created Successfully!");
            Console.Clear();
        }

    }
}
