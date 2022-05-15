using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using TdTutor.Models;

namespace TdTutor.Controllers
{
    public class LoginController : Controller
    {
        private readonly TdTutorDataContext _context;

        public LoginController(TdTutorDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login([Bind("nombre,contrasenia")] Docente docente)
        {
            Docente user = _context.Docente.Where(x => x.nombre == docente.nombre && x.contrasenia == docente.contrasenia).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                int cont = 0;
                HttpContext.Session.SetString("User", JsonConvert.SerializeObject(user));
                HttpContext.Session.SetInt32("cantidad", cont+1);
                return Redirect("/Docentes/Index?id=1");
            }
        }
    }
}
