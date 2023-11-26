using WebAPI1.Entities;
using WebAPI1.Repositories.Abstract;
using WebAPI1.Services.Abstract;

namespace WebAPI1.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddElement(Customer element)
        {
            _customerRepository.AddElement(element);
        }

        public void DeleteElement(int id)
        {
            _customerRepository.DeleteElement(id);
        }

        public IEnumerable<Customer> GetAllElements()
        {
            return _customerRepository.GetAllElements();
        }

        public Customer GetElement(int id)
        {
            return _customerRepository.GetElement(id);
        }

        public void UpdateElement(Customer element)
        {
            _customerRepository.UpdateElement(element);
        }
    }
}
