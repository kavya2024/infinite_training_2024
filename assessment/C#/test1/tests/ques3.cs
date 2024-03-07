using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Remove_Character
    {

       
        public void Remove_char()
        {
            Console.WriteLine("Enter any String : ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the character position you want to remove : " + s.Length + " is size of the given string");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the count of the charector to be removed");
            int count = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index < s.Length)
                Console.Write("After Removing the character  " + s.Remove(index, count));
            else
                Console.WriteLine("Invalid input");


        }
        static void Main(string[] args)
        {
            Remove_Character program = new Remove_Character();
            program.Remove_char();
            Console.WriteLine();
            // for getting the largest Int
            Largest_Int largest_Int = new Largest_Int();
            largest_Int.Largest();
            Console.WriteLine();
            
            Exch_FirstnLast_Char exch_FirstnLast_Char = new Exch_FirstnLast_Char();
            exch_FirstnLast_Char.Exchange_Char();


        }
    }
}