using System.Collections.Generic;

namespace TestTask2.Data.Repositories
{
    public interface IRepository<T, K>
    {
        IEnumerable<T> GetAll();
        T GetById(K id);
        void Create(T model);
        void Update(T model);
        void Delete(K id);
    }
}