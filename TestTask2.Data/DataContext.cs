using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask2.Data.Entities;
using TestTask2.Data.Migrations;

namespace TestTask2.Data
{
    internal class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataCOntext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<EquipmentEntity> Equipment { get; set; }


    }
}
