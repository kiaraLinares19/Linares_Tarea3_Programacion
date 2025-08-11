using Microsoft.AspNetCore.Mvc;
using Linares_Tarea3_Programacion.Models;
using System.Collections.Generic;

namespace Linares_Tarea3_Programacion.Controllers
{
    public class ProductoController : Controller
    {
        private List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Collar para perro", Precio = 15.50m },
            new Producto { Nombre = "Juguete de goma", Precio = 8.99m },
            new Producto { Nombre = "Comida para gato", Precio = 12.00m },
            new Producto { Nombre = "Cama para mascota", Precio = 45.00m },
            new Producto { Nombre = "Rascador para gato", Precio = 30.00m }
        };

        [HttpGet]
        public IActionResult Lista()
        {
            return View(productos);
        }

        [HttpPost]
        public IActionResult Confirmacion(List<string> seleccionados)
        {
            ViewBag.Seleccionados = seleccionados;
            return View();
        }
    }
}
