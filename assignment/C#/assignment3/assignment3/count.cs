using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count
{
    class count
    {
        static void Main()
        {
            Console.WriteLine("Enter the string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Convert.ToChar(Console.ReadLine());

            int count = CountOccurrences(inputString, letterToCount);

            Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the string.");
            Console.ReadLine();
        }

        static int CountOccurrences(string inputString, char letter)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
            
        }
    }
}
