namespace Order.API.Models.ViewModels
{
    public class CreateOrderVM
    {
        public Guid BuyerId { get; set; }
        public List<CreateOrderItemVm> OrderItems { get; set; }
    }

}
