using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeaShop.Models;
using TeaShop.Repository;

namespace TeaShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IImageService _imageService;
        private readonly IProductRepo _productRepo;
        private readonly ProductServiceEF _productservice;

        public ProductController (AppDbContext context,IProductService productService, IImageService imageService, IProductRepo productRepo)
        {
            _productService = productService;
            _imageService = imageService;
            _productRepo = productRepo;
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
            var model = new Product();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product model)
        {
            var status = 1;
            var message = "";
            if(model.ImageFile != null)
            {
                
                var fileResult = _imageService.SaveImage(model.ImageFile);
                var imageName = fileResult.Item2;
                model.ProductImage = imageName;

                var productResult = _productRepo.Add(model);
                if (productResult)
                {
                    _productService.Save(model);
                    status = 1;
                    message = "Dodano pomyślnie";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    status = 0;
                    message = "Błąd przy dodawaniu produktu";
                }
                
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _productService.FindById(id);
            return product is null ? NotFound() : View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_productService.Delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            return Problem("Próba usunięcia produkty który nie istnieje");
        }

        public IActionResult Edit(int? id)
        {
            var product = _productService.FindById(id);
            return product is null ? NotFound() : View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Name,Price,Weight,Description")] Product? product)
        {
            if (!ModelState.IsValid)
            {
                _productService.Update(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

    }
}
