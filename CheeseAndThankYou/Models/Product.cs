using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CheeseAndThankYou.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        [DisplayName("Stink Rating")]
        [Range(1, 5)]
        public int StinkRating { get; set;}
        public string Description { get; set; }

        [Range(0.01, 1000.00)]
        // Only applies to the html
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }

        // The image could be string but it also could be null
        public string? Photo { get; set; }
        public string Size { get; set; }

        // Foreign key
        [DisplayName("Category")]
        public int CategorId { get; set; }

        // Parant ref
        public Category? Category { get; set; }

        // Child ref
        public List<CartItem>? CartItems { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }

    }
}
