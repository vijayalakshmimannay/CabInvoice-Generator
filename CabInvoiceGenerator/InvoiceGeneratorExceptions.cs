using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{

    [Serializable]
    internal class InvoiceGeneratorExceptions : Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE, INVALID_DISTANCE, INVALID_MINUTE, NULL_RIDES, INVALID_USER_ID,
        }
        ExceptionType Type;
        public InvoiceGeneratorExceptions(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}