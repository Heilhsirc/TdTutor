
using System.Collections.Generic;
using System.Linq;
using TdTutor.Models;

namespace TdTutor.Controllers
{
    public class Metodos
    {
        private readonly TdTutorDataContext _context;

        public Metodos()
        {
        }

        public Metodos(TdTutorDataContext context)
        {
            _context = context;
        }

        public List<Materia> getMaterias()
        {
            return _context.Materia.ToList();
        }
    }
}
