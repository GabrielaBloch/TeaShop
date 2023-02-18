using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeaShop.Models;

namespace TeaShop.Repository
{
    public class UserOrderRepo : IUserOrderRepo

    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserOrderRepo(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        public async Task<IEnumerable<Order>> UserOrders()
        {
            var userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("Użytkownik nie jest zalogowany");
            }
            var orders = await _context.Orders
                                   .Include(x => x.OrderStatus)
                                   .Include(x => x.OrderDetail)
                                   .ThenInclude(x=>x.Product)
                                   .ThenInclude(x=>x.Category)
                                   .Where(a=>a.UserId==userId)
                                   .ToListAsync();
            return orders;                 
        }
        public string GetUserId()
        {
            var user = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(user);
            return userId;
        }

    }
}
