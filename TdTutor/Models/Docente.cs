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
        public string materia { get; set; }
        public string contrasenia { get; set; }
        public int rol { get; set; }
        public string nroDocumento { get; set; }
    }
}
