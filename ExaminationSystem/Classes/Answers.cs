using ExaminationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Classes
{
    public class Answer : ICloneable
    {
        public int AnswerId { get; }
        public string AnswerText { get; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString() => $"[{AnswerId}] {AnswerText}";

        public object Clone() => new Answer(AnswerId, AnswerText);
    }
}
