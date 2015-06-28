using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using TestTask2.Core;
using TestTask2.Data.Entities;

namespace TestTask2.Data.Repositories
{
    /// <summary>
    /// Репозитарий "Ссылки"
    /// </summary>
    public class LinkRepository : ILinkRepository
    {
        public IEnumerable<Link> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Link> GetByArticle(string article)
        {
            using (DataContext context = new DataContext())
            {
                List<LinkEntity> entities = context.Links.Where(x => x.Article == article).AsNoTracking().ToList();
                List<Link> models = Mapper.Map<List<LinkEntity>, List<Link>>(entities);
                return models;
            }
        }

        public Link GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Link model)
        {
            throw new NotImplementedException();
        }

        public void Update(Link model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}