using TeaShop.Models;

namespace TeaShop.Repository
{
    public interface IUserOrderRepo
    {
        Task<IEnumerable<Order>> UserOrders();
    }
}