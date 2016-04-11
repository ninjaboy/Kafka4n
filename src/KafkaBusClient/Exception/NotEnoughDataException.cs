
namespace KafkaBusClient.Exception
{
    public class NotEnoughDataException : KafkaException
    {
        public NotEnoughDataException(string message) : base(message)
        {
        }
    }
}
