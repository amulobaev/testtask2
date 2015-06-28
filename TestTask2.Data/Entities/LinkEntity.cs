using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask2.Data.Entities
{
    /// <summary>
    /// Сущность "Ссылка"
    /// </summary>
    public class LinkEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Артикул оборудования
        /// </summary>
        [MinLength(6)]
        [MaxLength(18)]
        [Required]
        public string Article { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        [ForeignKey("Article")]
        public EquipmentEntity EquipmentEntity { get; set; }
    }
}
