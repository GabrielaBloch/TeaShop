﻿using TeaShop.Models;

namespace TeaShop.Repository
{
    public interface ICartRepository
    {
        Task<int> AddItem(int productId, int quantity);
        Task<int> RemoveItem(int productId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task<bool> DoCheckout();

    }
}
