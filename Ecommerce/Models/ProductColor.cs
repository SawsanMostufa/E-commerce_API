using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
