using ExaminationSystem.Abstraction;
using ExaminationSystem.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    public class MCQ : Questions
    {
        public MCQ(string body ,int mark , List<string> choices , int CorrectAnsIdx) : base(HeaderQuestion.MCQ, body, mark)
        {
            for (int i = 0; i < choices.Count; i++)
            {
                AnswerList.Add(new Answer(i + 1, choices[i]));
            }

            if (CorrectAnsIdx >= 0 && CorrectAnsIdx < AnswerList.Count)
            {
                RightAnswer = AnswerList[CorrectAnsIdx];
            }
        }

        public override bool AskQues()
        {
            DisplayTheQuestion();

            int userChoice;
            do
            {
                Console.Write("Your Answer (Enter the Answer ID): ");
            } while (!int.TryParse(Console.ReadLine(), out userChoice));

            Answer? selected = null;
            foreach (var ans in AnswerList)
            {
                if (ans.AnswerId == userChoice)
                {
                    selected = ans;
                    break;
                }
            }

            if (selected == null)
            {
                Console.WriteLine("Invalid Answer.");
                return false;
            }

            bool correct = selected.AnswerId == RightAnswer?.AnswerId;

            Console.WriteLine(correct ? "Correct!" : $"Wrong! Correct: {RightAnswer}");
            return correct;
        }


    }

}


    

