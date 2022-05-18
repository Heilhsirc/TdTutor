using Microsoft.EntityFrameworkCore;
using TdTutor.Models;

namespace TdTutor.Models
{
    public class TdTutorDataContext : DbContext
    {
        public TdTutorDataContext(DbContextOptions<TdTutorDataContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Rector> Rector { get; set; }
        public DbSet<TdTutor.Models.Estudiante> Estudiante { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Rol> Rol { get; set; }
    }
}
