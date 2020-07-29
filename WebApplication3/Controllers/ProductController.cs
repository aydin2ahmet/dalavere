using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepostitory Repository;

        public ProductController(IProductRepostitory prod)
        {
            Repository = prod;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(Repository.product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            Repository.CreateProduct(product);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            var product = Repository.GetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Details(Product product)
        {
            Repository.UpdateProduct(product);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            Repository.DeleteProduct(id);
            return RedirectToAction("List");
        }
    }
}
