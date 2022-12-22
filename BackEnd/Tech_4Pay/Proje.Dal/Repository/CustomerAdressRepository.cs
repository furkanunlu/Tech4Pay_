using Microsoft.EntityFrameworkCore;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech_4Pay.EfDbContext;

namespace Proje.Dal
{
    public class CustomerAdressRepository: BaseRepository<CustomerAdress, DbContext>, ICustomerAdressRepository
    {
        public CustomerAdressRepository(DbContext context):base(context)
        { }
    }
}
