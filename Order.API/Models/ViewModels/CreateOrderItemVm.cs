namespace Order.API.Models.ViewModels
{
    public class CreateOrderItemVm
    {
        public string ProductId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
