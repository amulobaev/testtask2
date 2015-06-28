using System.Data.Entity.Migrations;

namespace TestTask2.Data.Migrations
{
    /// <summary>
    /// Конфигурация миграций
    /// </summary>
    internal class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
#if DEBUG
            AutomaticMigrationDataLossAllowed = true;
#endif
        }
    }
}
