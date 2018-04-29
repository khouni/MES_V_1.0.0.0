using System;
using System.Collections.Generic;
using System.Linq;
using MES.DATA.MODEL.Entity;
using Microsoft.EntityFrameworkCore;

namespace MES.DATA.CORE.GenericRepository
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
       where T : BaseEntity
    {
        protected DbContext Entities;

        protected readonly DbSet<T> Dbset;

        protected GenericRepository(DbContext context)
        {
            Entities = context;
            Dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {

            return Dbset.AsEnumerable();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = Dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual object Add(T entity)
        {
            return Dbset.Add(entity);
        }

        public virtual object Delete(T entity)
        {
            return Dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Entities.SaveChanges();
        }
    }
}
