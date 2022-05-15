using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdTutor.Models
{
    [Table("Materia", Schema = "Aplicacion")]
    public class Materia
    {
        
        [Key]
        public int id { get; set; }
        [Required]
        public string materia { get; set; }
    }
}
