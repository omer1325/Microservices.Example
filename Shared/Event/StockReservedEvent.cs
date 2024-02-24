using Shared.Event.Common;

namespace Shared.Event
{
    public class StockReservedEvent : IEvent
    {
        public Guid BuyerId { get; set; }
        public Guid OrderId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
