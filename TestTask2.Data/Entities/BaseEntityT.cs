using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2.Data.Entities
{
    /// <summary>
    /// Базовый класс для сущностей Entity Framework
    /// </summary>
    internal class BaseEntity<T>
    {
        /// <summary>
        /// Уникальный идентификатор, первичный ключ
        /// </summary>
        [Key]
        public T Key { get; set; }
    }
}
