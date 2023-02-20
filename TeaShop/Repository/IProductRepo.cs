using TeaShop.Models;

namespace TeaShop.Repository
{
    public interface IProductRepo
    {
        bool Add(Product model);
    }
}
