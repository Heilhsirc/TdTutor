using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TdTutor.Models;

namespace TdTutor.Controllers
{
    public class ChatWebSocketController : Controller {
        Metodos metodos = new Metodos();
        public static Dictionary<int, string> Salas =
        new Dictionary<int, string>()
        {
            {1,"Matematicas" },
            {2,"Ingles" },
            {3,"Español" }
        };

        public IActionResult Index()
        {

            return View("Index");
        }

        public IActionResult Room(int room)
        {
            List<Materia> materias = metodos.getMaterias();
            Docente user = new Docente();
            user = JsonConvert.DeserializeObject<Docente>(HttpContext.Session.GetString("User"));
            ViewData["user"] = user;            
            return View("Room", room);
        }
    }
}
