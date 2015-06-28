using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestTask2.Core;
using TestTask2.Data.Repositories;

namespace TestTask2.Controllers
{
    public class EquipmentController : ApiController
    {
        private readonly IEquipmentRepository _repository;

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