using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Yummy.Data;

namespace Yummy.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private AppDbContext _context { get; }

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Categories.ToList());
        }
    }
}
