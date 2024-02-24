using Shared.Event.Common;

namespace Shared.Event
{
    public class PaymentFailedEvent : IEvent
    {
        public Guid OrderId { get; set; }
        public string Message { get; set; }
    }
}
