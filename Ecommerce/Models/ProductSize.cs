using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ProductSize
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }
        public virtual Product Product { get; set; }

    }
}
