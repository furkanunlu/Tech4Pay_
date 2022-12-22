using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Proje.Dal
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);//kayıt
        void Update(T entity);//Güncelleme
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Listeleme  
        ResultMessage<T> Get(Expression<Func<T, bool>> filter);//Getir
    }
}