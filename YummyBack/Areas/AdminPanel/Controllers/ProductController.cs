using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Yummy.Data;
using Yummy.ViewModels;

namespace Yummy.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProductVM product = new ProductVM
            {
                Products = _context.Products.ToList(),
                ProductImages = _context.ProductImages.ToList(),
            };
            return View(product);
        }
    }
}
