using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() { Name = "Product1", Category = "Category1", Description = "Description1", Price = 10 },
                    new Product() { Name = "Product2", Category = "Category2", Description = "Description2", Price = 20 },
                    new Product() { Name = "Product3", Category = "Category3", Description = "Description3", Price = 30 },
                    new Product() { Name = "Product4", Category = "Category4", Description = "Description4", Price = 40 },
                    new Product() { Name = "Product5", Category = "Category5", Description = "Description5", Price = 50 }

                    );
                context.SaveChanges();
            }
        }
    }
}
