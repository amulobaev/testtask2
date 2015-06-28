using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestTask2.Core;
using TestTask2.Data.Repositories;

namespace TestTask2.Controllers
{
    /// <summary>
    /// Контроллер Web API для получения списка оборудования
    /// </summary>
    public class EquipmentController : ApiController
    {
        private readonly IEquipmentRepository _repository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="repository">Реализация репозитария оборудования</param>
        public EquipmentController(IEquipmentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Equipment> GetAllEquipment()
        {
            List<Equipment> equipment = _repository.GetAll().ToList();
            return equipment;
        }
    }
}