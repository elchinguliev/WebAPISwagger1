using WebAPI1.Entities;
using WebAPI1.Data;
using WebAPI1.Repositories.Abstract;

namespace WebAPI1.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public ProductRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddElement(Product element)
        {
            _dbContext.Products.Add(element);
            _dbContext.SaveChanges();
        }

        public void DeleteElement(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAllElements()
        {
            return _dbContext.Products;
        }

        public Product GetElement(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            return product;

        }

        public void UpdateElement(Product element)
        {
            _dbContext.Products.Update(element);
            _dbContext.SaveChanges();
        }
    }
}
