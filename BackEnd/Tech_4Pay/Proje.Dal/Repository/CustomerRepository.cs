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
    public class CustomerRepository : BaseRepository<Customer, DbContext>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        { }
    }
}
