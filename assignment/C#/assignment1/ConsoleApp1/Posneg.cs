using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posneg
{
    class Posneg
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0)
                {
                    Console.WriteLine(num1 + " is negative number");
                    Console.ReadLine();


                }
                else if (num1 > 0)
                {
                    Console.WriteLine(num1 + " is positive number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();

            }

            
        }
    }
}
