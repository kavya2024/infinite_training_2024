using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{

    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class ques1
    {
        static void Main(string[] args)
        {
            Undergraduate undergraduateStudent = new Undergraduate("ram", 12345, 75.0);
            Graduate graduateStudent = new Graduate("urvashi", 13689, 85.0);

            Console.WriteLine("Undergraduate student passed: " + undergraduateStudent.IsPassed(undergraduateStudent.Grade));
            Console.WriteLine("Graduate student passed: " + graduateStudent.IsPassed(graduateStudent.Grade));
            Console.ReadLine();

        }
    }

}