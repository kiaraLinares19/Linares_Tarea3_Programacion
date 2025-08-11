using Microsoft.AspNetCore.Mvc;
using Linares_Tarea3_Programacion.Models;

namespace Linares_Tarea3_Programacion.Controllers
{
    public class MascotaController : Controller
    {
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "Mascota registrada con éxito 🎉";
                return View("Confirmacion", mascota);
            }

            return View(mascota);
        }
    }
}
