using System.Collections.Generic;
using System.Linq;
using MES.DATA.CORE.GenericRepository;
using MES.DATA.MODEL;
using Microsoft.EntityFrameworkCore;

namespace MES.DATA.CORE.Repository
{
    public class MachineRepository : GenericRepository<Machine>, IMachineRepository
    {
        public MachineRepository(DbContext context)
            : base(context)
        {

        }
        public override IEnumerable<Machine> GetAll()
        {
            return Entities.Set<Machine>().AsEnumerable();
        }

        public Machine GetById(long id)
        {
            return Dbset.FirstOrDefault(x => x.Id == id);
        }
    }
}
