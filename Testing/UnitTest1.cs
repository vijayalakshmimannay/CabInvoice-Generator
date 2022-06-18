namespace CabInvoiceGenerator
{
    public class Tests
    {
        /*[Test]
         public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
         {
             double distance = 10;
             int time = 5, expected = 105;
             CabInvoiceGenerator.InvoiceGenerator example = new CabInvoiceGenerator.InvoiceGenerator(distance, time);
             Assert.AreEqual(expected, example.TotalFare());*/

        /* [Test]
         public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
         {
             double distance = 15;
             int time = 10, expected = 160;
             InvoiceGenerator getMethod = new InvoiceGenerator();
             Ride ride = new Ride(distance, time);
             Assert.AreEqual(expected, getMethod.TotalFare(ride));
         }
         [Test]
         public void GivenMultipleRideData_ShouldReturnExpectedTotalFare()
         {
             int expected = 365;
             InvoiceGenerator getMethod = new InvoiceGenerator();
             Ride[] ride = { new Ride(20, 10), new Ride(15, 5) };
             Assert.AreEqual(expected, getMethod.MultipleRides(ride));

         }
        */
        /* [Test]
         public void GivenMultipleRideData_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
         {
             InvoiceGenerator fare = new InvoiceGenerator();
             Ride[] ride = { new Ride(20, 20), new Ride(10, 5), new Ride(30, 30) };
             double totalFare = 655, numberOfRides = ride.Length, averageFare = totalFare / numberOfRides;
             EnhanceInvoice result = fare.MultipleRides(ride);
             Assert.AreEqual(totalFare, result.totalFare);
             Assert.AreEqual(averageFare, result.averageFare);
             Assert.AreEqual(numberOfRides, result.numberOfRides);
        */

        [Test]
        public void GivenMultipleRideData_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
        {
            InvoiceGenerator fare = new InvoiceGenerator();
            Ride[] ride = { new Ride(20, 20), new Ride(10, 5), new Ride(30, 30) };
            double totalFare = 655, numberOfRides = ride.Length, averageFare = totalFare / numberOfRides;
            EnhanceInvoice result = fare.MultipleRides(ride);
            Assert.AreEqual(totalFare, result.totalFare);
            Assert.AreEqual(averageFare, result.averageFare);
            Assert.AreEqual(numberOfRides, result.numberOfRides);

        }
        [Test]
        public void GivenUserID_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
        {
            RideRepository rideRepository = new RideRepository();
            Ride[] ride = { new Ride(50, 50), new Ride(20, 10), new Ride(10, 10) };
            double totalFare = 870, numberOfRides = ride.Length, averageFare = totalFare / numberOfRides;
            rideRepository.AddRides("First", ride);
            var result = rideRepository.UserInvoice("First");
            Assert.AreEqual(totalFare, result.totalFare);
            Assert.AreEqual(averageFare, result.averageFare);
            Assert.AreEqual(numberOfRides, result.numberOfRides);
        }
    }
}
