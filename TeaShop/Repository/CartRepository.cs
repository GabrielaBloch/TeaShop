using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeaShop.Models;

namespace TeaShop.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRepository(AppDbContext context, UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> AddItem(int productId, int quantity)
        {
            string userId = GetUserId();
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var cart = await GetCart(userId);
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("Użytkownik nie jest zalogowany");
                }
                if (cart is null)
                {
                    cart = new ShoppingCart
                    {
                        UserId = userId
                    };
                    _context.ShoppingCarts.Add(cart);
                }
                _context.SaveChanges();
                var cartItem = _context.CartDetails.FirstOrDefault(c => c.ShoppingCartId == cart.Id && c.ProductId == productId);
                if (cartItem is not null)
                {
                    cartItem.Quantity += quantity;
                }
                else
                {
                    var product = _context.Products.Find(productId);
                    cartItem = new CartDetails
                    {
                        ProductId = productId,
                        ShoppingCartId = cart.Id,
                        Quantity = quantity,
                        Price = product.Price

                    };
                    _context.CartDetails.Add(cartItem);
                }
                _context.SaveChanges();
                transaction.Commit();
                
            }
            catch (Exception e)
            {
                throw new Exception();
            }
            var totalItems = await GetCartItemCount(userId);
            return totalItems;
        }

        public async Task<int> RemoveItem(int productId)
        {
            string userId = GetUserId();
            try
            {
                
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("Użytkownik nie jest zalogowany");
                }
                var cart = await GetCart(userId);
                if (cart is null)
                {
                    throw new Exception("Koszyk jest pusty");
                }

                var cartItem = _context.CartDetails.FirstOrDefault(c => c.ShoppingCartId == cart.Id && c.ProductId == productId);
                if (cartItem is null)
                    throw new Exception("Nie ma produtków w koszyku");
                else if (cartItem.Quantity == 1)
                {
                    _context.CartDetails.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity = cartItem.Quantity - 1;
                }
                _context.SaveChanges();
                
            }
            catch (Exception e)
            {
                
            }
            var totalItems = await GetCartItemCount(userId);
            return totalItems;
        }

        public async Task<ShoppingCart> GetUserCart()
        {
            var userId = GetUserId();
            if (userId == null)
                throw new Exception("Invalid userid");
            var shoppingCart = await _context.ShoppingCarts
                                  .Include(a => a.CartDetail)
                                  .ThenInclude(a => a.Product)
                                  .ThenInclude(a => a.Category)
                                  .Where(a => a.UserId == userId).FirstOrDefaultAsync();
            return shoppingCart;
        }

        public async Task<ShoppingCart> GetCart( string userId)
        {
            var result = await _context.ShoppingCarts.FirstOrDefaultAsync(x => x.UserId == userId);
            return result;


        }
        public async Task<int> GetCartItemCount(string userId)
        {
            userId = GetUserId();
            var data = await (from cart in _context.ShoppingCarts
                              join cartDetail in _context.CartDetails
                              on cart.Id equals cartDetail.ShoppingCartId
                              where cart.UserId == userId
                              select new { cartDetail.Id }
                               ).ToListAsync();
            return data.Count;
        }

        public async Task<bool> DoCheckout()
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var userId = GetUserId();
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("Użytkownik nie jest zalogowany");

                }
                var cart = await GetCart(userId);
                if(cart is null)
                {
                    throw new Exception("Brak koszyka");
                }
                var cartDetail = _context.CartDetails.Where(a=>a.ShoppingCartId==cart.Id).ToList();
                if (cartDetail.Count == 0)
                {
                    throw new Exception("Koszyk jest pusty");
                }
                var order = new Order
                {
                    UserId = userId,
                    CreateDate = DateTime.UtcNow,
                    OrderStatusId=1,

                };
                _context.Orders.Add(order);
                _context.SaveChanges();
                foreach(var item in cartDetail)
                {
                    var orderDetail = new OrderDetails
                    {
                        ProductId = item.ProductId,
                        OrderId = order.Id,
                        Quantity = item.Quantity,
                        UnitPrice = item.Price,

                    };
                    _context.OrderDetails.Add(orderDetail);
                }
                _context.SaveChanges();

                _context.CartDetails.RemoveRange(cartDetail);
                _context.SaveChanges();
                transaction.Commit();
                return true;
                                                    
            }
            catch (Exception)
            {

                return false;
            }
        }

        public string GetUserId()
        {
            var user = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(user);
            return userId;
        }

        
    }
}
