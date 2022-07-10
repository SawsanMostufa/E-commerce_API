using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface ISizeRepository
    {
        int Delete(int id);
        List<ProductSize> GetAll();
        ProductSize GetById(int id);
        int Insert(ProductSize prod);
        int Update(int id, ProductSize prod);
    }
}
