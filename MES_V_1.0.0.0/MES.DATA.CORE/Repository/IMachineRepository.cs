using MES.DATA.MODEL;

namespace MES.DATA.CORE.Repository
{
    public interface IMachineRepository
    {
        Machine GetById(long id);
    }
}
