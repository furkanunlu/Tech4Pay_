using Proje.Dal;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Bll
{
    public interface ICustomerContactService
    {
        void Add(CustomerContact customerContact);
        void Update(CustomerContact customerContact);
        List<CustomerContact> GetList();
        ResultMessage<CustomerContact> Get(Expression<Func<CustomerContact, bool>> filter);
    }
}
