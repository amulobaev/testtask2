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
    /// Репозитарий "Примечания"
    /// </summary>
    public class NoteRepository : INoteRepository
    {
        static NoteRepository()
        {
            Mapper.CreateMap<NoteEntity, Note>();
        }

        public IEnumerable<Note> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetByArticle(string article)
        {
            using (DataContext context = new DataContext())
            {
                List<NoteEntity> entities = context.Notes.Where(x => x.Article == article).AsNoTracking().ToList();
                List<Note> models = Mapper.Map<List<NoteEntity>, List<Note>>(entities);
                return models;
            }
        }

        public Note GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Note model)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Note model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}