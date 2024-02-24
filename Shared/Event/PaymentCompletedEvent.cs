using Shared.Event.Common;

namespace Shared.Event
{
    public class PaymentCompletedEvent : IEvent
    {
        public Guid OrderId { get; set; }
    }
}
