namespace TeaShop.Models
{
    public interface IProductService
    {
        public int Save(Product? product);
        public bool Delete(int? id);
        public bool Update(Product product);
        public Product? FindById(int? id);
        public Product? FindByName(string name);
        public ICollection<Product> FindAll();
        public ICollection<Product> FindByCategory( Category category);
    }
}
