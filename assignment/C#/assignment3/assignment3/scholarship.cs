using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Scholarship
    {
        public double Marks { get; set; }
        public double Fees { get; set; }

        public Scholarship(double marks, double fees)
        {
            Marks = marks;
            Fees = fees;
        }

        public double Merit()
        {
            double scholarshipAmount = 0;

            if (Marks >= 70 && Marks <= 80)
            {
                scholarshipAmount = 0.2 * Fees; // 20% of fees
            }
            else if (Marks > 80 && Marks <= 90)
            {
                scholarshipAmount = 0.3 * Fees; // 30% of fees
            }
            else if (Marks > 90)
            {
                scholarshipAmount = 0.5 * Fees; // 50% of fees
            }

            return scholarshipAmount;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter student's marks:");
            double studentMarks = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total fees:");
            double totalFees = double.Parse(Console.ReadLine());

            Scholarship studentScholarship = new Scholarship(studentMarks, totalFees);

            double scholarshipAmount = studentScholarship.Merit();

            Console.WriteLine($"The scholarship amount is: {scholarshipAmount:C}");

            Console.ReadLine();
        }
    }
}