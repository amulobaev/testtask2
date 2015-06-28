using System.Collections.Generic;
using TestTask2.Core;

namespace TestTask2.Data.Repositories
{
    /// <summary>
    /// Интерфейс репозитария "Примечания"
    /// </summary>
    public interface INoteRepository : IRepository<Note, int>
    {
        /// <summary>
        /// Загрузка всех примечаний по указанному артикулу
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        IEnumerable<Note> GetByArticle(string article);
    }
}