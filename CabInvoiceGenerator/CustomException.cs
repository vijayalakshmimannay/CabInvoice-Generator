using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{
    [Serializable]
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE, INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALID_USER_ID
        }
        ExceptionType Type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}