using EcommerceStore.Domain.Entities;

namespace EcommerceStore.Domain.ViewModels
{
    public class OrderDetailsVM
    {
        public Order Order { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}