using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask2.Data.Entities
{
    public class NoteEntity
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
        /// Примечание
        /// </summary>
        [MaxLength(500)]
        public string NoteText { get; set; }

        [ForeignKey("Article")]
        public EquipmentEntity EquipmentEntity { get; set; }
    }
}
