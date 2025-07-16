using System;

namespace GradeCalculator
{
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int[] Marks { get; set; }

        // Constructor
        public Student(string name, int[] marks)
        {
            Name = name;
            Marks = marks;
        }

        // Method to calculate average
        public double CalculateAverage()
        {
            int total = 0;
            foreach (int mark in Marks)
            {
                total += mark;
            }
            return (double)total / Marks.Length;
        }

        // Method to get grade
        public string GetGrade()
        {
            double average = CalculateAverage();

            if (average >= 90) return "A";
            else if (average >= 80) return "B";
            else if (average >= 70) return "C";
            else if (average >= 60) return "D";
            else return "F";
        }
    }

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
