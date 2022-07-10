using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public interface IColoRepo
    {
        int Delete(int id);
        List<ProductColor> GetAll();
        ProductColor GetById(int id);
        int Insert(ProductColor prod);
        int Update(int id, ProductColor prod);
    }
}
