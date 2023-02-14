using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeaShop.Models;

namespace TeaShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View( _context.Categories.ToList());
        }

        public async Task<IActionResult> GetCategoryDetails(int Id)
        {
            var productList = await _context.Products.Where(x => x.CategoryId == Id).ToListAsync();

            return View(productList);
        }


    }
}
