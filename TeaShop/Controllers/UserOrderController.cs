using Microsoft.AspNetCore.Mvc;
using TeaShop.Repository;

namespace TeaShop.Controllers
{
    public class UserOrderController : Controller
    {
        private readonly IUserOrderRepo _userOrderRepo;

        public UserOrderController(IUserOrderRepo userOrderRepo)
        {
            _userOrderRepo = userOrderRepo;
        }
        public async Task<IActionResult> UserOrder()
        {
            var orders = await _userOrderRepo.UserOrders();
            return View(orders);
        }
    }
}
