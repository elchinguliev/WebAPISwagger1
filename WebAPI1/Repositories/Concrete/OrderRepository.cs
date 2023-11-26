using WebAPI1.Data;
using WebAPI1.Entities;
using WebAPI1.Repositories.Abstract;

namespace WebAPI1.Repositories.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public OrderRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddElement(Order element)
        {
            _dbContext.Orders.Add(element);
            _dbContext.SaveChanges();
        }

        public void DeleteElement(int id)
        {
            var element = _dbContext.Orders.FirstOrDefault(o => o.Id == id);
            _dbContext.Orders.Remove(element);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Order> GetAllElements()
        {
            return _dbContext.Orders;
        }

        public Order GetElement(int id)
        {
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == id);
            return order;
        }

        public void UpdateElement(Order element)
        {
            _dbContext.Orders.Update(element);
            _dbContext.SaveChanges();
        }
    }
}
