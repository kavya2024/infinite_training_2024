using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Sales_Details
    {
        int SalesNo;
        int ProductNo;
        double Price;
        DateTime dateTime;
        int Quantity;
        double TotalAmt;


        static void Main()
        {
            Sales_Details sd = new Sales_Details(15465, 756, 6, 2, dateTime: DateTime.Now);
            sd.Sales();
            sd.ShowData();
            Console.Read();
        }


        Sales_Details(int SalesNo, int ProductNo, double Price, int Quantity, DateTime dateTime)
        {
            this.SalesNo = SalesNo;
            this.ProductNo = ProductNo;
            this.Price = Price;
            this.Quantity = Quantity;
            this.dateTime = dateTime;
        }

        public void Sales()
        {
            TotalAmt = Quantity * Price;
        }
        public void ShowData()
        {
            Console.WriteLine("Sales Details-> ");
            Console.WriteLine($"Sales Number: {SalesNo}");
            Console.WriteLine($"Product Number: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Date of Sale: : {dateTime}");
        }
    }
}