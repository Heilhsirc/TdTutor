using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdTutor.Models
{
    [Table("Estudiante", Schema = "Aplicacion")]
    public class Estudiante
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string nroDocumento { get; set; }
    }
}
