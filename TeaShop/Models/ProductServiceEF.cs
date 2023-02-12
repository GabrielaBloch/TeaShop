using Microsoft.EntityFrameworkCore;

namespace TeaShop.Models
{
    public class ProductServiceEF : IProductService
    {
        private readonly AppDbContext _context;

        public ProductServiceEF(AppDbContext context)
        {
            _context = context;
        }   

        public bool Delete(int? id)
        {
            if (id is null)
            {
                return false;
            }
            var find = _context.Products.Find(id);
            if (find is not null)
            {
                _context.Products.Remove(find);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public ICollection<Product> FindAll()
        {
            return _context.Products.Include(product => product.Category).ToList();
        }

        public Product? FindById(int? id)
        {
            Product? product = _context.Products.Include(b => b.Category).FirstOrDefault(b => b.Id == id);
            _context.Entry(product).State = EntityState.Detached;
            return id is null ? null : product;
        }

        public ICollection<Product> FindByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Product? FindByName(string name)
        {
            Product? product = _context.Products.Include(b => b.Category).FirstOrDefault(b => b.Name == name);
            _context.Entry(product).State = EntityState.Detached;
            return name is null ? null : product;
        }

        public int Save(Product? product)
        {

            var entityEntry = _context.Products.Add(product);
            _context.SaveChanges();
            return entityEntry.Entity.Id;
        }

        public bool Update(Product product)
        {
            try
            {
                var find = _context.Products.Find(product.Id);
                if (find is not null)
                {
                    find.Name = product.Name;
                    find.Price = product.Price;
                    find.ProductPhoto = product.ProductPhoto;
                    find.Description = product.Description;
                    find.Amount = product.Amount;
                    find.Weight = product.Weight;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
        public void SaveChanges()
        {

            _context.SaveChanges();
        }
    }
}
