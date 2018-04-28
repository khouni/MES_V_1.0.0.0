using data.core.GenericRepository;
using data.core.Repository;
using data.core.UnitOfWork;
using MES.DATA.INFRASTRUCTURE.GenericServices;
using MES.DATA.INFRASTRUCTURE.UnitOfWork;
using MES.DATA.MODEL;

namespace MES.DATA.INFRASTRUCTURE.Services
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
