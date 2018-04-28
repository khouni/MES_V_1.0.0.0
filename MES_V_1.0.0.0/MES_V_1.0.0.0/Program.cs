using System;
using data.core;
using data.core.Repository;
using MES.DATA.INFRASTRUCTURE.Services;
using MES.DATA.INFRASTRUCTURE.UnitOfWork;
using MES.DATA.MODEL;

namespace MES_V_1._0._0._0
{
    class Program
    {
        /// <summary>
        /// First Project
        /// </summary>
        static void Main()
        {          
            using (var context = new MesDbContext())
            {
                // Create database
                context.Database.EnsureCreated();
                MachineRepository repository=new MachineRepository(context);
                UnitOfWork untiWork=new UnitOfWork(context);
                var machineService=new MachineService(untiWork, repository);
                machineService.Create(new Machine() {Code = "xxx"});
                foreach (var machine in machineService.GetAll() )
                {
                    Console.WriteLine(machine.Code);
                }
            }
            Console.ReadLine();
        }
    }
}
