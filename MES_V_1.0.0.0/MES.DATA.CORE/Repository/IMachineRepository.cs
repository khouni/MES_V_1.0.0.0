using MES.DATA.MODEL;

namespace data.core.Repository
{
    public interface IMachineRepository
    {
        Machine GetById(long id);
    }
}
