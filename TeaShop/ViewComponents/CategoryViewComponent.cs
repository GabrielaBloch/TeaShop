using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeaShop.Models;

namespace TeaShop.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public CategoryViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = await _appDbContext.Categories.ToListAsync();
            return View(item);
        }

    }
}
