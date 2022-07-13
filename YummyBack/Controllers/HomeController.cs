using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Yummy.Data;
using Yummy.Models;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Categories = _context.Categories.Where(ctg => !ctg.isDeleted).ToList(),
                Products = _context.Products.Where(p=> !p.isDeleted).ToList(),
                ProductImages = _context.ProductImages.ToList(),
            };
            return View(home);
        }
    }
}
