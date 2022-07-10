using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Image { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool HasDiscount { get; set; }
        public int PriceAfterDiscount { get; set; }

        public List<ProductColor> Colors { get; set; }
        public List<ProductSize> Sizes { get; set; }

        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }

        [JsonIgnore]
        public virtual List<Order> Orders { get; set; }

    }
}
