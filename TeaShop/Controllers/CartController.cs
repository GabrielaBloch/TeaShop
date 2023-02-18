using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Models;
using TeaShop.Repository;

namespace TeaShop.Controllers
{

    public class CartController : Controller
    {
        private readonly ICartRepository _cartrepo;



        public CartController(ICartRepository cartrepo)
        {
            _cartrepo = cartrepo;
        }

        public async Task<IActionResult> AddItem(int productId, int quantity=1, int redirect=0)
        {
            var cartCount = await _cartrepo.AddItem(productId, quantity);
            if (redirect == 0)
                return Ok(cartCount);

            return RedirectToAction("GetUserCart");


        }
        public async Task<IActionResult> RemoveItem(int productId)
        {
            var cartCount = await _cartrepo.RemoveItem(productId);
            return RedirectToAction("GetUserCart");
        }
        public async Task<IActionResult> GetUserCart()
        {
            var cart = await _cartrepo.GetUserCart();
            return View(cart);
        }
       
        public async Task<IActionResult> GetTotalItemInCart()
        {
            int cartItem = await _cartrepo.GetCartItemCount();
            return Ok(cartItem);
        }
        public async Task<IActionResult> Checkout()
        {
            bool isCheckout = await _cartrepo.DoCheckout();
            if (!isCheckout)
            {
                throw new Exception("Błąd podczas składania zamówienia");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
