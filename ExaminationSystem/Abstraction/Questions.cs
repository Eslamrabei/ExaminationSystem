using ExaminationSystem.Classes;
using ExaminationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Abstraction
{
    public abstract class Questions
    {

        public HeaderQuestion Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }

        public List<Answer> AnswerList { get; set; } = new();
        public Answer? RightAnswer { get; set; }

        public Questions(HeaderQuestion header , string body , int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\n[{Header}]  Mark: {Mark}");
            Console.WriteLine($"Q: {Body}");
            foreach (var ans in AnswerList)
            {
                Console.WriteLine(ans.ToString());
            }
        }

        public abstract bool Ask();


    }
}
