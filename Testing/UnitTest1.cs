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

        [Test]
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


    }
}
