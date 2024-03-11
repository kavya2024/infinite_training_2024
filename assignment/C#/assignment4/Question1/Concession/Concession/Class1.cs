using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        private const int TOTAL_FARE = 600;
        public void calculateConcession(int age, string name) 
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket, Name: {name}, Age: {age}");
            }
            else if (age > 60)
            {
                decimal seniorCitizenFare = TOTAL_FARE * 0.3m;
                Console.WriteLine($"Senior Citizen - {seniorCitizenFare}, Name: {name}, Age: {age}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - {TOTAL_FARE}, Name: {name}, Age: {age}");
            }
        }
    }
}
