using WebAPI1.Entities;
using WebAPI1.Services.Abstract;
using static WebAPI1.Repositories.Abstract.IProductService;

namespace WebAPI1.Services.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public void AddElement(Product element)
        {
            _productRepo.AddElement(element);
        }

        public void DeleteElement(int id)
        {
            _productRepo.DeleteElement(id);
        }

        public IEnumerable<Product> GetAllElements()
        {
            return _productRepo.GetAllElements();
        }

        public Product GetElement(int id)
        {
            return _productRepo.GetElement(id);
        }

        public void UpdateElement(Product element)
        {
            _productRepo.UpdateElement(element);
        }
    }
}
