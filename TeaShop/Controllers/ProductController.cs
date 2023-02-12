using Microsoft.AspNetCore.Mvc;
using TeaShop.Models;

namespace TeaShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController (AppDbContext context,IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        
        {
            return View(_productService.FindAll());
        }
        public IActionResult Details(int? id)
        {
            var product = _productService.FindById(id);
            return product is null ? NotFound() : View(product);
        }
        public IActionResult Create()
        {
            return View();
        }

    }
}
