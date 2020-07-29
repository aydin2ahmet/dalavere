using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IProductRepostitory
    {
        IQueryable<Product> product { get;  }
        void CreateProduct(Product product);
        Product GetById(int Id);
        void UpdateProduct(Product product);

        void DeleteProduct(int ProductId);
    }
}
