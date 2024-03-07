using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Customer
    {
        static int Customer_ID;
        static string Name;
        static int Age;
        static string Mobile_No;
        static string City;

        public Customer()
        {
        }
        public Customer(int Customer_Id, string name, int age, string mobile_No, string city)
        {
            Customer_ID = Customer_Id;
            Name = name;
            Age = age;
            Mobile_No = mobile_No;
            City = city;
        }

        ~Customer()      
        {
            Console.WriteLine("Object  Destroyed!");
            Console.Read();
        }
        static void DisplayCustomer()
        {
            Console.WriteLine($"Customer Id: {Customer_ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone Number: {Mobile_No}");
            Console.WriteLine($"City: {City}");

        }
        static void Main()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer(1, "ram", 12, "43564", "gkp");  
            Console.WriteLine("Customer Information---->");
            DisplayCustomer();     
            customer1 = null;
            customer2 = null;
            GC.Collect();
            Console.Read();
        }
    }
}