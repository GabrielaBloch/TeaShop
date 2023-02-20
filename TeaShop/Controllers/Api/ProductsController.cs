using Microsoft.AspNetCore.Mvc;
using TeaShop.Models;
using TeaShop.Repository;

namespace TeaShop.Controllers.Api
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IImageService _imageService;
        private readonly IProductRepo _productRepo;
        private readonly ProductServiceEF _productserviceef;
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context, IProductService productService, IImageService imageService, IProductRepo productRepo)
        {
            _productService = productService;
            _imageService = imageService;
            _productRepo = productRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product?>>> GetProducts()
        {
            if (_productService is null)
            {
                return NotFound();
            }
            return new ActionResult<IEnumerable<Product?>>(_productService.FindAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetBook(int id)
        {
            if (_productService == null)
            {
                return NotFound();
            }

            var book = _productService.FindById(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_productService == null)
            {
                return NotFound();
            }
            var book = _productService.Delete(id);
            if (book == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
