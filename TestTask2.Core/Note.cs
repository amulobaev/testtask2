using System;

namespace TestTask2.Core
{
    /// <summary>
    /// Примечание
    /// </summary>
    public class Note
    {
        public int Id { get; set; }

        /// <summary>
        /// Артикул оборудования
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string NoteText { get; set; }
    }
}
