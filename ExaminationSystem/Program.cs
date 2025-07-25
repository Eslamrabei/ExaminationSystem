using ExaminationSystem.Classes;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Examination System";

            Console.Write("Enter Subject Id: ");
            int.TryParse(Console.ReadLine(), out int id);

            Console.Write("Enter Subject Name: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) name = "OOP_EXAM";
            Console.Clear();
            var subject = new Subject(id == 0 ? 1 : id, name);
            subject.CreateExam();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}
