using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class EfProductRepository : IProductRepostitory
    {
        private ApplicationDbContext _context;

        public EfProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> product => _context.Products;

        public void CreateProduct(Product product){
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int ProductId)
        {
            var product = GetById(ProductId);
            if(product!=null){
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public Product GetById(int Id)
        {
            return _context.Products.FirstOrDefault(i => i.ProductId == Id);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
