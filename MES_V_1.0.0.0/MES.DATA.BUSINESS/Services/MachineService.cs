using MES.DATA.BUSINESS.GenericServices;
using MES.DATA.CORE.GenericRepository;
using MES.DATA.CORE.Repository;
using MES.DATA.CORE.UnitOfWork;
using MES.DATA.MODEL;

namespace MES.DATA.BUSINESS.Services
{
    public class MachineService : EntityService<Machine>, IMachineService
    {
        IUnitOfWork _unitOfWork;

        private readonly IMachineRepository _machineRepository;

        public MachineService(IUnitOfWork unitOfWork, IGenericRepository<Machine> machineRepository)
          : base(unitOfWork, machineRepository)
      {
            _unitOfWork = unitOfWork;
            _machineRepository = (IMachineRepository)machineRepository;
        }


        public Machine GetById(int Id)
        {
            return _machineRepository.GetById(Id);
        }
    }
}
