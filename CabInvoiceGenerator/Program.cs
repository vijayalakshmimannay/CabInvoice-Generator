using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Console.WriteLine("Enter distance you want to Ride");
             int input1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter time of your journey in minutes");
             int input2 = Convert.ToInt32(Console.ReadLine());
             InvoiceGenerator getMethod = new InvoiceGenerator(input1,input2);
             double fare = getMethod.TotalFare();
             Console.WriteLine("Fare: " + fare);
            
            Ride[] ride = { new Ride(10, 10), new Ride(10, 5) };
            InvoiceGenerator getMethod = new InvoiceGenerator();
            double fare = getMethod.MultipleRides(ride); */
            InvoiceGenerator name = new InvoiceGenerator();
            Ride[] ride = { new Ride(20, 20), new Ride(10, 5), new Ride(30, 30) };
            EnhanceInvoice invoice = name.MultipleRides(ride);
            Console.WriteLine("TotalFare: " + invoice.totalFare + "\nNumberOfRides: " + invoice.numberOfRides + "\nAverage Fare: " + invoice.averageFare);
        }
    }

    
}