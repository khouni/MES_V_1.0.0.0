using System.Collections.Generic;
using MES.DATA.MODEL.Entity;

namespace MES.DATA.INFRASTRUCTURE.GenericServices
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
