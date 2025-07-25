using ExaminationSystem.Abstraction;
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Classes
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam? Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.WriteLine($"Creating Exam for Subject: {SubjectName}");

            int examType;
            do
            {
                Console.WriteLine("Choose Exam Type:\n[1] Final\n[2] Practical");
            } while (!int.TryParse(Console.ReadLine(), out examType) || examType < 1 || examType > 2);

            int duration;
            do
            {
                Console.Write("Enter Exam Duration in minutes (30 - 180): ");
            } while (!int.TryParse(Console.ReadLine(), out duration) || duration < 30 || duration > 180);
            
            int questionCount;
            do
            {
                Console.Write("Enter number of questions (1 - 10): ");
            } while (!int.TryParse(Console.ReadLine(), out questionCount) || questionCount < 1 || questionCount > 10);

            Exam = examType == 1 ? new Final(duration) : new Practical(duration);

            for (int i = 0; i < questionCount; i++)
            {
                Console.Clear();
                Console.WriteLine($"\nCreating Question #{i + 1}");

                int qType;
                if (examType == 1) 
                {
                    do
                    {
                        Console.WriteLine("Question Type:\n[1] True/False\n[2] MCQ");
                    } while (!int.TryParse(Console.ReadLine(), out qType) || qType < 1 || qType > 2);
                }
                else 
                {
                    qType = 2;
                }

                Console.Write("Enter question body: ");
                string? body = Console.ReadLine() ?? "";

                int mark;
                do
                {
                    Console.Write("Enter mark for this question: ");
                } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

                if (qType == 1) // True/False
                {
                    Console.Write("Enter correct answer (T for True, F for False): ");
                    string? ans = Console.ReadLine()?.ToUpper();
                    bool correctIsTrue = ans == "T";
                    Exam.QuestionsList.Add(new TrueOrFalse(body, mark, correctIsTrue));
                }
                else // MCQ
                {
                    List<string> choices = new();
                    Console.WriteLine("Enter 4 choices:");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{(char)(65 + j)}: ");
                        string? choice = Console.ReadLine();
                        choices.Add(choice ?? $"Option {(char)(65 + j)}");
                    }

                    int correctIndex;
                    do
                    {
                        Console.Write("Enter correct answer index [1-4]: ");
                    } while (!int.TryParse(Console.ReadLine(), out correctIndex) || correctIndex < 1 || correctIndex > 4);

                    Exam.QuestionsList.Add(new MCQ(body, mark, choices, correctIndex - 1));
                }
            }

            Console.Clear();
            Console.WriteLine("\nExam created successfully.");
            Console.WriteLine("Do you want to start the exam now? (Y/N): ");
            string? start = Console.ReadLine()?.ToUpper();

            if (start == "Y")
            {
                
                Exam.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam saved. You can take it later.");
            }
        }
    }
}
