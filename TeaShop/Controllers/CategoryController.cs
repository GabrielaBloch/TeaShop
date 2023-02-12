using Microsoft.AspNetCore.Mvc;

namespace TeaShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
