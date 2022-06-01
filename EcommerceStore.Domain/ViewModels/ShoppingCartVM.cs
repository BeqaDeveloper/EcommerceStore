using EcommerceStore.Domain.Entities;

namespace EcommerceStore.Domain.ViewModels
{
    /* This view model is for displaying the cart items at the shopping cart page */
    public class ShoppingCartVM
    {
        public IEnumerable<CartItem> CartItems { get; set; }
        public Order Order { get; set; }
    }
}
