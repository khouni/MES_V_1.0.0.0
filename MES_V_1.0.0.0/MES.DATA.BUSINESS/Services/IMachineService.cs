using MES.DATA.INFRASTRUCTURE.GenericServices;
using MES.DATA.MODEL;

namespace MES.DATA.INFRASTRUCTURE.Services
{
    public interface IMachineService : IEntityService<Machine>
    {
        Machine GetById(int Id);
    }
}
