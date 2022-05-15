using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdTutor.Models
{
    [Table("Docente", Schema = "Aplicacion")]
    public class Docente
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string materia { get; set; }
        [Required]
        public string contrasenia { get; set; }
    }
}
