using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TdTutor.Controllers
{
    public class ChatWebSocketController : Controller { 
        public static Dictionary<int, string> Salas = new Dictionary<int, string>()
        {
            {1,"Matematicas" },
            {2,"Ingles" },
            {3,"Español" }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
