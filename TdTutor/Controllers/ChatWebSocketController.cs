using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using TdTutor.Models;

namespace TdTutor.Controllers
{
    public class ChatWebSocketController : Controller {
        private readonly TdTutorDataContext _context;

        public ChatWebSocketController(TdTutorDataContext context)
        {
            _context = context;
        }
        public static Dictionary<int, string> Salas =
        new Dictionary<int, string>();

        public IActionResult Index()
        {
            List<Materia> materias = _context.Materia.ToList();
            for (int i = 0; i < materias.Count; i++)
            {
                Salas.Add(materias[i].id, materias[i].materia.ToString());
            }
            return View("Index");
        }

        public IActionResult Room(int room)
        {
            Docente user = new Docente();
            user = JsonConvert.DeserializeObject<Docente>(HttpContext.Session.GetString("User"));
            ViewData["user"] = user;            
            return View("Room", room);
        }
    }
}
