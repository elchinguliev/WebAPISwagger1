using WebAPI1.Dtos;
using WebAPI1.Entities;

namespace WebAPI1.Services.Abstract
{
    public interface IProductService : IService<Product>
    {
        public IEnumerable<ProductDto> GetHigherDiscount()
        {
            var products = GetAllElements().OrderByDescending(x => x.ProductDiscount);
            var dataToReturn = products.Select(p =>
            {
                return new ProductDto
                {
                    ProductDiscount = p.ProductDiscount,
                    ProductName = p.ProductName,
                    ProductPrice = p.ProductPrice,
                    Id = p.Id
                };
            });
            return dataToReturn;
        }
    }
}
