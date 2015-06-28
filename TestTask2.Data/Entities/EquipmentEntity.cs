using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2.Data.Entities
{
    /// <summary>
    /// Сущность "Оборудование"
    /// </summary>
    internal class EquipmentEntity
    {
        /// <summary>
        /// Артикул оборудования
        /// </summary>
        [Key]
        [MinLength(6)]
        [MaxLength(18)]
        public string Article { get; set; }

        /// <summary>
        /// Описание оборудования
        /// </summary>
        [MaxLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [Range(0.0, 15000.0)]
        public double Price { get; set; }

        /// <summary>
        /// Индикатор “На складе”
        /// </summary>
        public bool InStock { get; set; }
    }
}
