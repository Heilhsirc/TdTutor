using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdTutor.Models
{
    [Table("Rector", Schema = "Aplicacion")]
    public class Rector
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
    }
}
