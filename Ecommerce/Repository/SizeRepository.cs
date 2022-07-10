using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public class SizeRepository : ISizeRepository
    {
        Context context;
        public SizeRepository(Context _context)
        {
            context = _context;
        }
        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductSize> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ProductSize GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(ProductSize prod)
        {
            context.ProductSize.Add(prod);
            context.SaveChanges();
            return prod.Id;
        }

        public int Update(int id, ProductSize prod)
        {
            throw new System.NotImplementedException();
        }
    }
}
