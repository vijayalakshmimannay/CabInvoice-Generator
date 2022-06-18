using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> user;
        public RideRepository()
        {
            this.user = new Dictionary<string, List<Ride>>();
        }
        public void AddRides(string userid, Ride[] rides)
        {
            bool result = this.user.ContainsKey(userid);
            try
            {
                if (!result)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    user.Add(userid, list);
                }
            }
            catch (InvoiceGeneratorExceptions)
            {
                throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
        }
        public Ride[] GetRides(string userid)
        {
            try
            {
                return this.user[userid].ToArray();
            }
            catch (Exception)
            {
                throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_USER_ID, "Invalid UserID");
            }
        }
        public EnhanceInvoice UserInvoice(string userid)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Console.WriteLine("UserID: " + userid);
            return invoiceGenerator.MultipleRides(GetRides(userid));
        }
    }
}

