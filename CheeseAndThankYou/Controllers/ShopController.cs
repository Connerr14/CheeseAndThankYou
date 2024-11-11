using CheeseAndThankYou.Data;
using CheeseAndThankYou.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseAndThankYou.Controllers
{
    public class ShopController : Controller
    {
        // DB connection for all methods in the controller
        private readonly ApplicationDbContext _context;

        // Constructor with DB connection dependency (DI - dependency injection) one object needs another object
        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch the list of categories
            var categories = _context.Categories.ToList();
            // Passing the list to the view
            return View(categories);
        }

        // Get: /Shop/ByCategory
        public IActionResult ByCategory(int id)
        {
            // Make sure we have a valid Category id
            // Fetch list of products in selected category and pass to view
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            var products = _context.Products.Where(p => p.CategorId == id).ToList();

            return View(products);
        }
    }
}


