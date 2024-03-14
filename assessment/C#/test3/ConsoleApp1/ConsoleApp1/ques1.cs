using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test3
{
    class ques1
    {
        static void Main(string[] args)
        {
            string filePath = "output.txt";
            string textToAppend = "Text to append.";

            try
            {
              
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(textToAppend);
                }

                Console.WriteLine("Text appended successfully.");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
               
            }
        }
    }
}