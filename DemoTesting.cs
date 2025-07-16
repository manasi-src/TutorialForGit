using System;

namespace GradeCalculatorTesting
{
    class StudentTesting
    {
        // Properties
        public string Name { get; set; }
        public int[] Marks { get; set; }

        // Constructor
        public StudentTesting(string name, int[] marks)
        {
            Name = name;
            Marks = marks;
        }
    }
}