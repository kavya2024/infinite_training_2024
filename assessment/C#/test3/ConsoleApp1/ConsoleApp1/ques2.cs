using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    delegate int CalculatorOperation(int num1, int num2);
    class ques2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Functionalities:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");

            Console.Write("Enter your choice: ");//user's choice
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Console.Write("Enter first number: ");
            int num1;
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.Write("Enter second number: ");
            int num2;
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            CalculatorOperation operation = null;
            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
            }

            if (operation != null)
            {
                int result = operation(num1, num2);
                Console.WriteLine("Result: " + result);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Invalid operation!");
               
            }
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
