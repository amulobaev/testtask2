using System.Collections.Generic;
using TestTask2.Core;

namespace TestTask2.Data.Repositories
{
    /// <summary>
    /// Интерфейс репозитария "Ссылки"
    /// </summary>
    public interface ILinkRepository : IRepository<Link, int>
    {
        /// <summary>
        /// Загрузка всех ссылок по указанному артикулу
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        IEnumerable<Link> GetByArticle(string article);
    }
}