using System.ComponentModel.DataAnnotations;

namespace Linares_Tarea3_Programacion.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especie es obligatoria")]
        public string Especie { get; set; }

        [Range(0, 30, ErrorMessage = "La edad debe estar entre 0 y 30")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El color es obligatorio")]
        public string Color { get; set; }
    }
}
