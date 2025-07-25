using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Abstraction
{
    public abstract class Exam
    {
        

        public int TimeOfExam { get; set; }
        public List<Questions> QuestionsList { get; set; }
        public int NumberOfQuestions => QuestionsList.Count ;
        

        public Exam(int timeofexam)
        {
            TimeOfExam = timeofexam;
            QuestionsList = new List<Questions>();
        }

        public abstract void ShowExam();


        


    }
}
