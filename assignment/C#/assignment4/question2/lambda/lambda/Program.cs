using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 7,2,30 }; 

            var query = from number in numbers
                        let square = number * number
                        where square > 20
                        select new { Number = number, Square = square };

            foreach (var result in query)
            {
                Console.WriteLine("Number: {0}, Square: {1}", result.Number, result.Square);
            }

            Console.Read();
        }
    }
}