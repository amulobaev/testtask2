using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2.Core
{
    /// <summary>
    /// Ссылка
    /// </summary>
    public class Link
    {
        public int Id { get; set; }

        /// <summary>
        /// Артикул оборудования
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}
