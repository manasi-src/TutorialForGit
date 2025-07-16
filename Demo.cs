using System;

namespace GradeCalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            int[] marks = new int[3];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student student = new Student(name, marks);

            Console.WriteLine($"\nStudent: {student.Name}");
            Console.WriteLine($"Average Marks: {student.CalculateAverage()}");
            Console.WriteLine($"Grade: {student.GetGrade()}");
        }
    }
}
