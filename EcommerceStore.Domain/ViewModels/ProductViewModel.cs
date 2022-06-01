using EcommerceStore.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace EcommerceStore.Domain.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public List<string> Categories { get; set; }

        [Required(ErrorMessage = "Must set at least one category for the product.")]
        [MinLength(1)]
        public List<long> CategoryIds { get; set; }
    }
}
