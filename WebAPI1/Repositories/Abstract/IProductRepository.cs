using WebAPI1.Dtos;
using WebAPI1.Entities;
using WebAPI1.Services.Abstract;

namespace WebAPI1.Repositories.Abstract
{
    public interface IProductService : IService<Product>
    {
        public interface IProductRepository : IRepository<Product>
        {
        }
    }
}
