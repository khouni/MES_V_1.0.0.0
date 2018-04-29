using System;
using MES.DATA.BUSINESS.Services;
using MES.DATA.CORE.Repository;
using MES.DATA.CORE.UnitOfWork;
using MES.DATA.MODEL;
using MES.MYSQL.DATA.CONNECT;

namespace MES_V_1._0._0._0
{
    class Program
    {
        static void Main()
        {
            using (var context = new MesDbContext())
            {
                // Create database
                context.Database.EnsureCreated();
                var repository = new MachineRepository(context);
                UnitOfWork untiWork = new UnitOfWork(context);
                var machineService = new MachineService(untiWork, repository);
                machineService.Create(new Machine() { Code = "xxxx77" });
                foreach (var machine in machineService.GetAll())
                {
                    Console.WriteLine(machine.Code);
                }
            }
            Console.ReadLine();
        }
    }
}
