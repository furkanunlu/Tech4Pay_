using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Proje.Dal
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        private DbContext _context;
        public void Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public ResultMessage<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            TEntity data1=_context.Set<TEntity>().FirstOrDefault(filter);
            return data1 == null ? new ResultMessage<TEntity> { } : new ResultMessage<TEntity> { };
               // TEntity data = _context.Set<TEntity>().FirstOrDefault(filter);
                //return data == null ? new ResultMessage<TEntity> { isTrue = false, Data = null, Message = "Aranan kriterlere uygun kayıt bulunamadı" } :
                   // new ResultMessage<TEntity> { isTrue = true, Data = data, Message = "Kayıt getirildi." };
            
            
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}