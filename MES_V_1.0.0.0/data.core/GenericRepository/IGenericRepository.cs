using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MES.DATA.MODEL.Entity;

namespace data.core.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        object Add(T entity);
        object Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
