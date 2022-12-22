using Proje.Entity;
using Proje.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Bll
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        List<Customer> GetList();
        ResultMessage<Customer> Get(Expression<Func<Customer, bool>> filter);
    }
}
