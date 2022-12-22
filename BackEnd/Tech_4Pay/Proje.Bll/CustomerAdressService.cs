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
    public class CustomerAdressService : ICustomerAdressService
    {
        
        private readonly IBaseRepository<CustomerAdress> _customerAdressRepository;
        
        public CustomerAdressService(IBaseRepository<CustomerAdress> customerAdressRepository)
        {
            _customerAdressRepository = customerAdressRepository;
        }
        public void Add(CustomerAdress customerAdress)
        {
            _customerAdressRepository.Add(customerAdress);
            
        }

        public List<CustomerAdress> GetList()
        {
            return _customerAdressRepository.GetAll();
            
        }

        public void Update(CustomerAdress customerAdress)
        {
            _customerAdressRepository.Update(customerAdress);
        }
        public ResultMessage<CustomerAdress> Get(Expression<Func<CustomerAdress, bool>> filter) => _customerAdressRepository.Get(filter);

    }
}
