using MES.DATA.BUSINESS.GenericServices;
using MES.DATA.MODEL;

namespace MES.DATA.BUSINESS.Services
{
    public interface IMachineService : IEntityService<Machine>
    {
        Machine GetById(int Id);
    }
}
