using ExaminationSystem.Abstraction;
using ExaminationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    public class Practical:Exam
    {
        public Practical(int timeOfExam) : base(timeOfExam) { }

        public override void ShowExam()
        {
            Console.Clear();
            Console.WriteLine("\t Practical Exam \t\n");

            int totalMark = 0;
            int obtainedMark = 0;

            foreach (var question in QuestionsList)
            {
                totalMark += question.Mark;

                Console.WriteLine("---------<------------------>-------------");
                bool correct = question.AskQues();
                if (correct) obtainedMark += question.Mark;
                Console.WriteLine($"Correct Answer: {question.RightAnswer}");
                Console.WriteLine();
            }

            Console.WriteLine($"Your Grade: {obtainedMark} / {totalMark}");
            Console.WriteLine();
        }

        




    }
}
