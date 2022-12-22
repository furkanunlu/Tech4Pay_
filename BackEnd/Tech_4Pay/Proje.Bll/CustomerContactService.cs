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
    public class CustomerContactService : ICustomerContactService
    {
        private readonly IBaseRepository<CustomerContact> _customerContactRepository;
        public CustomerContactService(IBaseRepository<CustomerContact> customerContactRepository)
        {
            _customerContactRepository = customerContactRepository;
        }
        public void Add(CustomerContact customerContact)
        {
            _customerContactRepository.Add(customerContact);
        }

        public List<CustomerContact> GetList()
        {
            return _customerContactRepository.GetAll();
        }

        public void Update(CustomerContact customerContact)
        {
            _customerContactRepository.Update(customerContact);
        }
        public ResultMessage<CustomerContact> Get(Expression<Func<CustomerContact, bool>> filter) => _customerContactRepository.Get(filter);
    }
}
