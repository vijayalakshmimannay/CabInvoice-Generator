using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public enum RideType { NORMAL, PREMIUM }
    public class InvoiceGenerator
    {
        private readonly double MINIMUM_COST_PER_KM;
        private readonly int COST_PER_MINUTE;
        private readonly double MINIMUM_FARE;
        public InvoiceGenerator(RideType rideType)
        {
            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_MINUTE = 1;
                    this.MINIMUM_FARE = 5;
                }
                if (rideType.Equals(RideType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_MINUTE = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (InvoiceGeneratorExceptions)
            {
                throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_RIDE_TYPE, "Invalid Ride Type");
            }
        }
        public double CalculateFare(Ride ride)
        {
            double totalFare = 0;
            if (ride.distance >= 0 && ride.time >= 0)
            {
                totalFare = ride.distance * MINIMUM_COST_PER_KM + ride.time * COST_PER_MINUTE;
            }
            else
            {
                if (ride.distance <= 0)
                {
                    throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (ride.time < 0)
                {
                    throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_MINUTE, "Invalid Time");
                }
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
        public EnhanceInvoice MultipleRides(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (var ride in rides)
                {
                    totalFare += CalculateFare(ride);
                }
            }
            catch (InvoiceGeneratorExceptions)
            {
                throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
            return new EnhanceInvoice(rides.Length, totalFare);
        }
    }
}

