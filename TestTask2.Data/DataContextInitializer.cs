using System.Data.Entity;
using TestTask2.Data.Entities;

namespace TestTask2.Data
{
    /// <summary>
    /// Инициализатор контекста
    /// </summary>
    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        /// <summary>
        /// Добавление тестовых данных
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DataContext context)
        {
            #region Оборудование

            context.Equipment.Add(new EquipmentEntity
            {
                Article = "013G2920",
                Description =
                    "С газонаполненным встроенным температурным датчиком",
                Price = 1000,
                InStock = true
            });

            context.Equipment.Add(new EquipmentEntity
            {
                Article = "014G0051",
                Description =
                    "электронный программируемый, комплектуется двумя адаптерами (RA + K М30х1,5)",
                Price = 1010,
                InStock = true
            });

            context.Equipment.Add(new EquipmentEntity
            {
                Article = "023Z0012",
                Description = "Жидкостной фильтр-осушитель",
                Price = 2010,
                InStock = false
            });

            #endregion Оборудование
        }
    }
}
