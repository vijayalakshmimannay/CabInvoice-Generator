using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Enter distance you want to Ride");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time of your journey in minutes");
            int input2 = Convert.ToInt32(Console.ReadLine());
            InvoiceGenerator getMethod = new InvoiceGenerator(input1, input2);
            double fare = getMethod.TotalFare();
            Console.WriteLine("Fare: " + fare);*/

            /* Ride[] ride = { new Ride(10, 10), new Ride(10, 5) };
             InvoiceGenerator getMethod = new InvoiceGenerator();
             double fare = getMethod.MultipleRides(ride);*/

            /* InvoiceGenerator name = new InvoiceGenerator();
             Ride[] ride = { new Ride(20, 20), new Ride(10, 5), new Ride(30, 30) };
             EnhanceInvoice invoice = name.MultipleRides(ride);
             Console.WriteLine("TotalFare: " + invoice.totalFare + "\nNumberOfRides: " + invoice.numberOfRides + "\nAverage Fare: " + invoice.averageFare);*/

            /* RideRepository rideRepository = new RideRepository();
             Ride[] first = { new Ride(50, 50), new Ride(20, 10), new Ride(10, 10) };
             rideRepository.AddRides("First", first);
             Ride[] second = { new Ride(20, 10), new Ride(10, 5), new Ride(30, 20) };
             rideRepository.AddRides("Second", second);
             var invoice = rideRepository.UserInvoice("First");
             Console.WriteLine("TotalFare: " + invoice.totalFare + "\nNumberOfRides: " + invoice.numberOfRides + "\nAverage Fare: " + invoice.averageFare);*/

            InvoiceGenerator newMethod = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 20;
            int time = 5;
            Ride ride = new Ride(distance, time);
            double result = newMethod.CalculateFare(ride);
            Console.WriteLine("Total Fare: " + result);

        }
    }

    
}