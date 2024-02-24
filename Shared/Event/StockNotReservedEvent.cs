using Shared.Event.Common;

namespace Shared.Event
{
    public class StockNotReservedEvent : IEvent
    {
        public Guid BuyerId { get; set; }
        public Guid OrderId { get; set; }
        public string Message { get; set; }
    }
}
