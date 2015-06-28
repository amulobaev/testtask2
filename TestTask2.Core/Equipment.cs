using System;

namespace TestTask2.Core
{
    /// <summary>
    /// Оборудование
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Артикул оборудования
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Описание оборудования
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Индикатор “На складе”
        /// </summary>
        public bool InStock { get; set; }
    }
}
