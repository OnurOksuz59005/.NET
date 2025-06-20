using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Task5_EF_InMemory.Data;
using Task5_EF_InMemory.Models;

namespace Task5_EF_InMemory.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;

            // Add default data if empty
            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product { Name = "Notebook" });
                _context.Products.Add(new Product { Name = "Pen" });
                _context.Products.Add(new Product { Name = "Laptop" });
                _context.SaveChanges();
            }
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
