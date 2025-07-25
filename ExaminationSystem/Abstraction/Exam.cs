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


        public  void StartTimer()
        {
            int totalSeconds = TimeOfExam * 60;

            Thread timerThread = new Thread(() =>
            {
                while (totalSeconds > 0)
                {
                    Console.Title = $"Time Left: {totalSeconds / 60:D2}:{totalSeconds % 60:D2}";
                    Thread.Sleep(1000);
                    totalSeconds--;
                }

                Console.Clear();
                Console.WriteLine("\nTime is up! The exam will now end.");
                Environment.Exit(0); 
            });

            timerThread.IsBackground = true;
            timerThread.Start();
        }


    }
}
