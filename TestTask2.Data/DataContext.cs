using System.Data.Entity;
using TestTask2.Data.Entities;

namespace TestTask2.Data
{
    /// <summary>
    /// Контекст данных Entity Framework
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DataContext()
            : base("name=DataContext")
        {
        }

        public DbSet<EquipmentEntity> Equipment { get; set; }

        /// <summary>
        /// Настройка инициализатора контекста
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DataContextInitializer());

            base.OnModelCreating(modelBuilder);
        }
    }
}