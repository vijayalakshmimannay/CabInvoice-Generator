namespace CabInvoiceGenerator
{
    public class EnhanceInvoice
    {
        public double numberOfRides;
        public double totalFare;
        public double averageFare;
        public EnhanceInvoice(double numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }
    }
}