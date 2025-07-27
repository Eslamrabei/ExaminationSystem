using ExaminationSystem.Abstraction;
using ExaminationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    public class Final:Exam
    {
        
        public Final(int timeofexam) : base(timeofexam)
        {
        }

        public override void ShowExam()
        {
            Console.Clear();
            Console.WriteLine("\t Final Exam \t\n");

            int totalMark = 0;
            int obtainedMark = 0;

            Dictionary<Questions, bool> results = new();

            foreach (var question in QuestionsList)
            {
                totalMark += question.Mark;

                Console.WriteLine("------------<-------------->--------------");
                bool correct = question.AskQues();
                results[question] = correct;
                if (correct) obtainedMark += question.Mark;
                Console.WriteLine();
            }

            Console.WriteLine("\n\t Exam Summary \t");
            foreach (var q in QuestionsList)
            {
                q.DisplayTheQuestion();
                Console.WriteLine($"Your answer was: {(results[q] ? "Correct" : "Wrong")}");
                Console.WriteLine($"The Correct Answer : {q.RightAnswer}\n");
            }

            Console.WriteLine($"Your Grade: {obtainedMark} / {totalMark}");
        }

        

    }
}
