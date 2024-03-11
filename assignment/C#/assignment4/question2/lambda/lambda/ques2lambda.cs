using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lambda
{
    class ques2lambda
    {
        public static void Main()
        {
            List<string> words = new List<string> { "amsterdam", "bloom","aaammm","kavya"}; 

            var query = from word in words
                        where word[0] == 'a' && word[word.Length - 1] == 'm'
                        select word;

            foreach (var word in query)
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}