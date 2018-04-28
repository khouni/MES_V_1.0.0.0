
using System;
using System.Collections.Generic;
using data.core;
using data.core.Repository;
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
            
            using (var context = new MesdbContext())
            {
                // Create database
                context.Database.EnsureCreated();
                MachineRepository repository=new MachineRepository(context);

                foreach (var machine in repository.GetAll() )
                {
                    Console.WriteLine(machine.Code);
                }
            }
            Console.ReadLine();
        }
    }
}
