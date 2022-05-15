using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdTutor.Models
{
    public class Materia
    {
        [Table("Materia", Schema = "Aplicacion")]
        public class Docente
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string materia { get; set; }
        }
    }
}
