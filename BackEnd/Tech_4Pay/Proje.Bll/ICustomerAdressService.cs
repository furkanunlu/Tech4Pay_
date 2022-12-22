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
    public interface ICustomerAdressService
    {
        void Add(CustomerAdress customerAdress);
        void Update(CustomerAdress customerAdress);
        List<CustomerAdress> GetList();
        ResultMessage<CustomerAdress> Get(Expression<Func<CustomerAdress,bool>> filter);
    }
}
