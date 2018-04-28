using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data.core.GenericRepository;
using MES.DATA.MODEL;
using Microsoft.EntityFrameworkCore;

namespace data.core.Repository
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
