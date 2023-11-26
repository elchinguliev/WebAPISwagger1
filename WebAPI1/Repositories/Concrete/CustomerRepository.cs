using WebAPI1.Data;
using WebAPI1.Entities;
using WebAPI1.Repositories.Abstract;

namespace WebAPI1.Repositories.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public CustomerRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddElement(Customer element)
        {
            _dbContext.Customers.Add(element);
            _dbContext.SaveChanges();
        }

        public void DeleteElement(int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == id);
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAllElements()
        {
            return _dbContext.Customers;
        }

        public Customer GetElement(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }

        public void UpdateElement(Customer element)
        {
            _dbContext.Customers.Update(element);
            _dbContext.SaveChanges();
        }
    }
}
