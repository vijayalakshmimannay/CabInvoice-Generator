namespace CabInvoiceGenerator
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
        {
            double distance = 10;
            int time = 5, expected = 105;
            CabInvoiceGenerator.InvoiceGenerator example = new CabInvoiceGenerator.InvoiceGenerator(distance, time);
            Assert.AreEqual(expected, example.TotalFare());
        }


    }
}
