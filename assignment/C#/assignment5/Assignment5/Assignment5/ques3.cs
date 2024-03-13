using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5
{
    //Creating class Employee
    class Employee
    {
        //initializing members
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee(int empId, string empName, float salary) // constructor with parameters
        {
            Empid = empId;
            Empname = empName;
            Salary = salary;
        }
    }

 
    class PartTimeEmployee : Employee
    {
        public float Wages { get; set; }

        public PartTimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary) 
        {
            Wages = wages;
        }
    }

    class ques3
    {
        static void Main()
        {
            
            PartTimeEmployee partTimeEmp = new PartTimeEmployee(12345, "Ramesh", 435000.0f, 5450.0f);

      
            Console.WriteLine($"Employee ID: {partTimeEmp.Empid}");
            Console.WriteLine($"Employee Name: {partTimeEmp.Empname}");
            Console.WriteLine($"Base Salary: {partTimeEmp.Salary:C}");
            Console.WriteLine($"Wages (Part-time): {partTimeEmp.Wages:C}");
            Console.Read();
        }
    }
}