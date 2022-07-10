using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repository
{
    public class ColorRepo : IColoRepo
    {

        Context context;
        public ColorRepo(Context _context)
        {
            context = _context;
        }
        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductColor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ProductColor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(ProductColor prod)
        {
            context.ProductColor.Add(prod);
            context.SaveChanges();
            return prod.Id;
        }

        public int Update(int id, ProductColor prod)
        {
            throw new System.NotImplementedException();
        }
    }
}
