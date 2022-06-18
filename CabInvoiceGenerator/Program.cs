using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter distance you want to Ride");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time of your journey in minutes");
            int input2 = Convert.ToInt32(Console.ReadLine());
            InvoiceGenerator getMethod = new InvoiceGenerator(input1, input2);
            double fare = getMethod.TotalFare();
            Console.WriteLine("Fare: " + fare);

        }

    }
}