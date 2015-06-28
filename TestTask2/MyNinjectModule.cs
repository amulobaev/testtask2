using System;
using Ninject.Modules;
using TestTask2.Data.Repositories;

namespace TestTask2
{
    public class MyNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEquipmentRepository, EquipmentRepository>();
        }
    }
}