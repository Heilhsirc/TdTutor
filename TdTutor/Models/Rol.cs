using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdTutor.Models
{
    [Table("Rol", Schema = "Aplicacion")]
    public class Rol
    {
        [Key]
        public int id { get; set; }
        public string rol { get; set; }
    }
}
