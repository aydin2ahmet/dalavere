using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class FakeProductRepository : IProductRepostitory
    {
        public IQueryable<Product> product => new List<Product>
        {
               new Product(){ProductId = 1,Name ="Prdocut1",Description = "Description1",Price = 10,Category = "Category1"},
               new Product(){ProductId = 2,Name ="Prdocut2",Description = "Description2",Price = 20,Category = "Category2"},
               new Product(){ProductId = 3,Name ="Prdocut3",Description = "Description3",Price = 30,Category = "Category3"},
               new Product(){ProductId = 4,Name ="Prdocut4",Description = "Description4",Price = 40,Category = "Category4"},
               new Product(){ProductId = 5,Name ="Prdocut5",Description = "Description5",Price = 50,Category = "Category5"}

        }.AsQueryable();

        public void CreateProduct(Product product){

        }

        public void DeleteProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
