using Proje.Dal;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tech_4Pay.EfDbContext;

namespace Proje.Bll
{
    public class CustomerService : ICustomerService
    {
        private readonly IBaseRepository<Customer> _customerRepository;
        public CustomerService(IBaseRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Add(Customer customer)
        {
            char[] vowels = new char[] { 'a', 'i', 'ı', 'e', 'o', 'ö', 'ü', 'u' };
            int occurence = 0;
            var gelen = customer.Ad.ToLower();
            foreach(char vowel in vowels)
            {
                occurence = gelen.Count(c => c == vowel);
                if (occurence >= 3)
                {
                    customer.Anormal = true;
                    break;
                }
            }

            
            _customerRepository.Add(customer);
        }

        public List<Customer> GetList()
        {
            return _customerRepository.GetAll();
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
        }
        public ResultMessage<Customer> Get(Expression<Func<Customer, bool>> filter) => _customerRepository.Get(filter);
    }
}
