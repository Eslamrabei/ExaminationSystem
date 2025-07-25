using ExaminationSystem.Abstraction;
using ExaminationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    public class TrueOrFalse : Questions
    {
        public TrueOrFalse(string body, int mark, bool rightIsTrue)
            : base(HeaderQuestion.TrueOrFalse, body, mark)
        {
            
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));

            RightAnswer = rightIsTrue ? AnswerList[0] : AnswerList[1];
        }

        public override bool Ask()
        {
            Display();

            Console.Write("Your Answer (1 for True, 2 for False): ");

            int userChoice;
            while (!int.TryParse(Console.ReadLine(), out userChoice) || (userChoice != 1 && userChoice != 2))
            {
                Console.Write("Invalid. Enter 1 (True) or 2 (False): ");
            }

            
            Answer? selected = null;
            for (int i = 0; i < AnswerList.Count; i++)
            {
                if (AnswerList[i].AnswerId == userChoice)
                {
                    selected = AnswerList[i];
                    break;
                }
            }

            bool correct = RightAnswer != null && selected != null && selected.AnswerId == RightAnswer.AnswerId;
            Console.WriteLine(correct ? "Correct!" : $"Wrong! The Correct Answer is:: {RightAnswer}");
            return correct;
        }


    }
}
