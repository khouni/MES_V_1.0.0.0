using System.Collections.Generic;
using MES.DATA.MODEL.Entity;

namespace MES.DATA.BUSINESS.GenericServices
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        void Create(T entity);        
        void Update(T entity);
        void Delete(T entity);
    }
}
