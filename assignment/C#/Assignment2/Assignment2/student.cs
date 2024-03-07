using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Student
    {
        int RollNo;
        String Name;
        String Class;
        int Semester;
        String Branch;
        int[] Marks = new int[5];
        int Sum;

        static void Main()
        {
            Student student = new Student(1, "ram", "B.tech", 67, "EC");
            student.InputData();
              
            student.DisplayResult();
            Console.Read();

        }

        public Student(int RollNo, String Name, String Class, int Semester, String Branch)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Class = Class;
            this.Semester = Semester;
            this.Branch = Branch;
        }
        public void InputData()
        {
            Console.WriteLine("Enter the marks of five subject: ");
            for (int i = Marks.Length - 1; i >= 0; i--)
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            

        }
        public void DisplayResult()
        {
            Console.WriteLine("-----Student Information-----");
            Console.WriteLine($"Roll Number-> {RollNo}");
            Console.WriteLine($"Name-> {Name}");
            Console.WriteLine($"Class-> {Class}");
            Console.WriteLine($"Semester-> {Semester}");
            Console.WriteLine($"Brnach-> {Branch}");
            Console.WriteLine("---Marks---");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Marks of Subject {i + 1}: {Marks[i]}");
                Sum = Marks[i] + Sum;
            }
            Console.WriteLine("---Result---");
            Console.WriteLine($"Total Marks obtain by Student-> {Sum}");
            Console.WriteLine("Avarage Marks-> " + Sum / Marks.Length);

        }
    }
}