﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TestTask2.Core;
using TestTask2.Data.Entities;

namespace TestTask2.Data.Repositories
{
    /// <summary>
    /// Репозитарий "Оборудование"
    /// </summary>
    public class EquipmentRepository : IEquipmentRepository
    {
        static EquipmentRepository()
        {
            // Настройка маппинга
            Mapper.CreateMap<EquipmentEntity, Equipment>();
        }

        /// <summary>
        /// Получение всех сущностей из репозитария
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Equipment> GetAll()
        {
            using (DataContext context = new DataContext())
            {
                List<EquipmentEntity> entities = context.Equipment.AsNoTracking().ToList();
                List<Equipment> models = Mapper.Map<List<EquipmentEntity>, List<Equipment>>(entities);
                return models;
            }
        }

        public Equipment GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Create(Equipment model)
        {
            throw new NotImplementedException();
        }

        public void Update(Equipment model)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}